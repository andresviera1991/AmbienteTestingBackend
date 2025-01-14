using System;
using MGP.Authentication.Persistance.Interface;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using AutoMapper;
using MGP.Authentication.Persistance.Data.Tables;
using System.Threading.Tasks;
using MGP.Authentication.Domain.Models;
using Confluent.Kafka;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.Persistance.Data.Enum;
using System.Linq;

namespace MGP.Authentication.Domain.Services;

public class UserService : IUserService
{
    private readonly ILogger<UserService> _logger;
    private readonly IEmailService _emailService;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    private readonly IParentService _parentService;
    private readonly IJwtValidator _jwtValidator;
    private readonly IEncryptionService _encryptionService;
    private readonly IMapper _mapper;
    private readonly IAuditService _auditService;
    public const int USUARIOELIMINADO = 4;

    public UserService(ILogger<UserService> logger,
                       IUserRepository userRepository,
                       IParentService parentService,
                       IMapper mapper,
                       IJwtValidator jwtValidator,
                       IEncryptionService encryptionService,
                       IAuditService auditService,
                       IEmailService emailService,
                       IJwtTokenGenerator jwtTokenGenerator)
    {
        _logger = logger;
        _userRepository = userRepository;
        _parentService = parentService;
        _mapper = mapper;
        _jwtValidator = jwtValidator;
        _encryptionService = encryptionService;
        _auditService = auditService;
        _emailService = emailService;
        _jwtTokenGenerator = jwtTokenGenerator;
    }


    #region REGISTER METHODS
    public async Task<Guid> RegisterAsync(UserData user)
    {
        user.Password = _encryptionService.HashPassword(user.Password);
        var userRegistered = await _userRepository.RegisterAsync(_mapper.Map<User>(user));

        if (CommonHelper.IsUnderage(user.Person.BirthDate))
        {
            user.Person.Parent.PersonId = userRegistered.PersonId;
            await _parentService.AddAsync(user.Person.Parent);
        }

        await SendEmailValidorAsync(userRegistered);

        userRegistered.Password = "";
        await _auditService.SendAudit(new AuditData(
            userRegistered.Id,
            "POST",
            "User",
            userRegistered.Id.ToString(),
            "",
            JsonSerializer.Serialize(userRegistered)
        ));

        return userRegistered.Id;
    }

    public async Task<Guid> RegisterByAgentAsync(UserData userData)
    {
        userData.Password = _encryptionService.HashPassword(userData.Person.DocumentNumber);
        var userRegistered = await _userRepository.RegisterAsync(_mapper.Map<User>(userData), true);

        if (CommonHelper.IsUnderage(userData.Person.BirthDate))
        {
            userData.Person.Parent.PersonId = userRegistered.PersonId;
            await _parentService.AddAsync(userData.Person.Parent);
        }

        return userRegistered.Id;
    }

    #endregion

    #region GET METHODS
    public async Task<UserData> GetUserByUserNameAsync(string userName)
    {
        User user = await _userRepository.GetUserByUserNameAsync(userName);
        return _mapper.Map<UserData>(user);
    }

    public async Task<UserData> GetUserByIdAsync(Guid id)
    {
        var userData = _mapper.Map<UserData>(await _userRepository.GetUserByIdAsync(id));
        userData.Person.Parent = _mapper.Map<ParentData>(await _userRepository.GetParentByPersonId(userData.PersonId));
        return userData;
    }

    public async Task<List<Guid>> ListUserIdsByFilterAsync(string fullName, string documentNumber)
    {
        return await _userRepository.ListUserIdsByFilterAsync(fullName, documentNumber);
    }

    public async Task<List<ResumeUserData>> ListUsersByFilterAsync(string fullName, string documentNumber, int pageSize, int pageNumber)
    {
        var users = await _userRepository.ListUsersByFilterAsync(fullName, documentNumber, pageSize, pageNumber);

        return (from user in users
                select new ResumeUserData()
                {
                    Id = user.Id,
                    FullName = (user.Person.Name + " " + user.Person.LastName),
                    Status = new() { Description = user.UserStatus.Description, Id = user.UserStatusId },
                    DocumentNumber = user.Person.DocumentNumber,
                    BirthDate = user.Person.BirthDate
                }).ToList();
    }
    #endregion

    #region UPDATE METHODS
    public async Task<UserData> PatchUserAsync(UserDataToUpdate userToUpdate)
    {

        User user = await _userRepository.GetUserByIdAsync(userToUpdate.Id.Value);

        userToUpdate.Id = null;
        var jsonOld = JsonSerializer.Serialize(user);

        if (!string.IsNullOrEmpty(userToUpdate.Email) && !user.Email.Equals(userToUpdate.Email))
        {
            user.Email = userToUpdate.Email;
            user.UserStatusId = (int)UserStatusType.USER_INACTIVE;
            await SendEmailValidorAsync(user);
        }
        else
        {
            userToUpdate.Email = null;
        }

        if (userToUpdate.UserStatusId != null)
        {
            user.UserStatusId = (int)userToUpdate.UserStatusId;
        }

        if (user.Person != null && userToUpdate.Person != null)
        {
            UpdatePerson(user, userToUpdate.Person);

            if (userToUpdate.Person.BirthDate > DateTime.Today.AddYears(-18) && userToUpdate.Person.Parent != null)
            {
                await _userRepository.UpdateParentToPerson(_mapper.Map<Parent>(userToUpdate.Person.Parent), user.PersonId);
            }

            if (user.Person.Address != null && userToUpdate.Person.Address != null)
            {
                UpdatePersonAddress(user, userToUpdate.Person.Address);
            }
            if (user.Person.PhoneNumber != null && userToUpdate.Person.PhoneNumber != null)
            {
                UpdatePersonPhoneNumber(user, userToUpdate.Person.PhoneNumber);
            }
        }

        User userUpdated = await _userRepository.UpdateAsync(user);

        await _auditService.SendAudit(new AuditData(
            userUpdated.Id,
            "PATCH",
            "User",
            userUpdated.Id.ToString(),
            jsonOld,
            JsonSerializer.Serialize(userToUpdate)
        ));

        var userData = _mapper.Map<UserData>(userUpdated);
        userData.Password = "";
        return userData;
    }

    private static void UpdatePersonPhoneNumber(User user, PhoneNumberData PhoneNumberData)
    {
        PhoneNumberData.Number = !string.IsNullOrEmpty(PhoneNumberData.Number) && !user.Person.PhoneNumber.Number.Equals(PhoneNumberData.Number) ? PhoneNumberData.Number : null;
        user.Person.PhoneNumber.Number = !string.IsNullOrEmpty(PhoneNumberData.Number) ? PhoneNumberData.Number : user.Person.PhoneNumber.Number;
    }

    private static void UpdatePersonAddress(User user, AddressDataToUpdate addressDataToUpdate)
    {
        addressDataToUpdate.Street = !string.IsNullOrEmpty(addressDataToUpdate.Street) && !user.Person.Address.Street.Equals(addressDataToUpdate.Street) ? addressDataToUpdate.Street : null;
        user.Person.Address.Street = !string.IsNullOrEmpty(addressDataToUpdate.Street) ? addressDataToUpdate.Street : user.Person.Address.Street;

        addressDataToUpdate.StreetNumber = !string.IsNullOrEmpty(addressDataToUpdate.StreetNumber) && !user.Person.Address.StreetNumber.Equals(addressDataToUpdate.StreetNumber) ? addressDataToUpdate.StreetNumber : null;
        user.Person.Address.StreetNumber = !string.IsNullOrEmpty(addressDataToUpdate.StreetNumber) ? addressDataToUpdate.StreetNumber : user.Person.Address.StreetNumber;

        addressDataToUpdate.Floor = !string.IsNullOrEmpty(addressDataToUpdate.Floor) && !user.Person.Address.Floor.Equals(addressDataToUpdate.Floor) ? addressDataToUpdate.Floor : null;
        user.Person.Address.Floor = !string.IsNullOrEmpty(addressDataToUpdate.Floor) ? addressDataToUpdate.Floor : user.Person.Address.Floor;

        addressDataToUpdate.Apartment = !string.IsNullOrEmpty(addressDataToUpdate.Apartment) && !user.Person.Address.Apartment.Equals(addressDataToUpdate.Apartment) ? addressDataToUpdate.Apartment : null;
        user.Person.Address.Apartment = !string.IsNullOrEmpty(addressDataToUpdate.Apartment) ? addressDataToUpdate.Apartment : user.Person.Address.Apartment;

        addressDataToUpdate.BetweenStreetOne = !string.IsNullOrEmpty(addressDataToUpdate.BetweenStreetOne) && !user.Person.Address.BetweenStreetOne.Equals(addressDataToUpdate.BetweenStreetOne) ? addressDataToUpdate.BetweenStreetOne : null;
        user.Person.Address.BetweenStreetOne = !string.IsNullOrEmpty(addressDataToUpdate.BetweenStreetOne) ? addressDataToUpdate.BetweenStreetOne : user.Person.Address.BetweenStreetOne;

        addressDataToUpdate.BetweenStreetTwo = !string.IsNullOrEmpty(addressDataToUpdate.BetweenStreetTwo) && !user.Person.Address.BetweenStreetTwo.Equals(addressDataToUpdate.BetweenStreetTwo) ? addressDataToUpdate.BetweenStreetTwo : null;
        user.Person.Address.BetweenStreetTwo = !string.IsNullOrEmpty(addressDataToUpdate.BetweenStreetTwo) ? addressDataToUpdate.BetweenStreetTwo : user.Person.Address.BetweenStreetTwo;

        addressDataToUpdate.LocalityId = addressDataToUpdate.LocalityId != null && user.Person.Address.LocalityId != addressDataToUpdate.LocalityId ? addressDataToUpdate.LocalityId : null;
        user.Person.Address.LocalityId = addressDataToUpdate.LocalityId != null ? addressDataToUpdate.LocalityId.Value : user.Person.Address.LocalityId;
    }

    private static void UpdatePerson(User user, PersonDataToUpdate personDataToUpdate)
    {
        personDataToUpdate.DocumentNumber = !string.IsNullOrEmpty(personDataToUpdate.DocumentNumber) && !user.Person.DocumentNumber.Equals(personDataToUpdate.DocumentNumber) ? personDataToUpdate.DocumentNumber : null;
        user.Person.DocumentNumber = !string.IsNullOrEmpty(personDataToUpdate.DocumentNumber) ? personDataToUpdate.DocumentNumber : user.Person.DocumentNumber;
        user.UserName = !string.IsNullOrEmpty(personDataToUpdate.DocumentNumber) ? personDataToUpdate.DocumentNumber : user.Person.DocumentNumber;

        personDataToUpdate.Name = !string.IsNullOrEmpty(personDataToUpdate.Name) && !user.Person.Name.Equals(personDataToUpdate.Name) ? personDataToUpdate.Name : null;
        user.Person.Name = !string.IsNullOrEmpty(personDataToUpdate.Name) ? personDataToUpdate.Name : user.Person.Name;

        personDataToUpdate.LastName = !string.IsNullOrEmpty(personDataToUpdate.LastName) && !user.Person.LastName.Equals(personDataToUpdate.LastName) ? personDataToUpdate.LastName : null;
        user.Person.LastName = !string.IsNullOrEmpty(personDataToUpdate.LastName) ? personDataToUpdate.LastName : user.Person.LastName;

        personDataToUpdate.BirthDate = personDataToUpdate.BirthDate != null && user.Person.BirthDate != personDataToUpdate.BirthDate ? personDataToUpdate.BirthDate : null;
        user.Person.BirthDate = personDataToUpdate.BirthDate != null ? personDataToUpdate.BirthDate.Value : user.Person.BirthDate;

        personDataToUpdate.GenderId = personDataToUpdate.GenderId != null && user.Person.GenderId != personDataToUpdate.GenderId ? personDataToUpdate.GenderId : null;
        user.Person.GenderId = personDataToUpdate.GenderId != null ? personDataToUpdate.GenderId.Value : user.Person.GenderId;

        personDataToUpdate.Resident = personDataToUpdate.Resident != null && user.Person.Resident != personDataToUpdate.Resident ? personDataToUpdate.Resident : null;
        user.Person.Resident = personDataToUpdate.Resident != null ? personDataToUpdate.Resident.Value : user.Person.Resident;
    }
    #endregion

    #region DELETE METHOD
    public async Task DeleteUserAsync(Guid id)
    {
        try
        {
            User user = await _userRepository.GetUserByIdAsync(id);
            string jsonOld = JsonSerializer.Serialize(new { user.UserStatusId });
            user.UserStatusId = (int)UserStatusType.USER_DELETED;
            User userUpdated = await _userRepository.UpdateAsync(user);
            await _auditService.DeleteTickets(id);

            await _auditService.SendAudit(new AuditData(
                userUpdated.Id,
                "DELETE",
                "User",
                userUpdated.Id.ToString(),
                jsonOld,
                JsonSerializer.Serialize(new { userUpdated.UserStatusId })
            ));

            _logger.LogInformation($"Message sent");
        }
        catch (ProduceException<Null, string> e)
        {
            _logger.LogInformation(e, "Error: {Reason}", e.Error.Reason);
        }
    }


    #endregion

    #region VALIDATE METHOD
    private async Task SendEmailValidorAsync(User user)
    {
        string token = await _jwtTokenGenerator.GenerateEmailTokenAsync(user.Id);
        var emailBody = (await _emailService.GetEmailTemplateAsync(EmailTemplateType.VALIDATE_USER)).Replace("{token}", token);
        await _emailService.SendEmailAsync(user.Email, "Validacion de usuario", emailBody);
    }

    public async Task ValidateUserAsync(string token)
    {
        TokenInformation tokenInformation = await _jwtValidator.ValidateEmailTokenAsync(token);
        await _userRepository.ValidateUserAsync(tokenInformation.UserId);
    }

    #endregion

}