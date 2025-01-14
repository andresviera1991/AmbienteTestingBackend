using MGP.Authentication.CrossCutting.Helpers;
using AutoMapper;
using MGP.Authentication.Persistance.Data.Tables;
using MGP.Authentication.Application.UseCase.V1.Authentication.Login;
using MGP.Authentication.Application.UseCase.V1.Authentication.Register;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.API.Controllers.V1.Auth.Request.Register;
using MGP.Authentication.API.Controllers.V1.ResetPassword.Request;
using MGP.Authentication.API.Controllers.V1.Auth.Request.Login;
using MGP.Authentication.Application.UseCase.V1.Authentication.Logout;
using MGP.Authentication.Application.UseCase.V1.User.Update;
using MGP.Authentication.Application.UseCase.V1.User.GetUser;
using MGP.Authentication.Application.UseCase.V1.User.GetUser.Response;
using MGP.Authentication.API.Controllers.V1.User.Request;
using MGP.Authentication.Application.UseCase.V1.Catalog.Gender;
using MGP.Authentication.Application.UseCase.V1.User.Delete;
using MGP.Authentication.Application.UseCase.V1.Password.Reset;
using MGP.Authentication.Application.UseCase.V1.Password.Change;
using MGP.Authentication.Application.UseCase.V1.User.Update.Request;
using MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;
using MGP.Authentication.Application.UseCase.V1.Authentication.RegisterByAgent;
using MGP.Authentication.API.Controllers.V1.Auth.Request.RegisterByAgent;
using MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;
using MGP.Authentication.Application.UseCase.V1.Catalog.UserStatus;

namespace MGP.Authentication.API.Helpers;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        ModelToRequest();
        RequestToDTO();
        DTOToEntity();
        ModelToDTO();
        EntityToDTO();
        DTOToResponse();
    }

    private void ModelToRequest()
    {
        CreateMap<RegisterRequestModel, RegisterRequest>();
        CreateMap<RegisterByAgentRequestModel, RegisterByAgentRequest>();
        CreateMap<LoginRequestModel, LoginRequest>();
        CreateMap<ResetPasswordRequestModel, ResetPasswordRequest>();
        CreateMap<LogoutRequestModel, LogoutRequest>();
        CreateMap<UpdateUserRequestModel, UpdateUserRequest>();
        CreateMap<UpdateUserForEmployeRequestModel, UpdateUserRequest>();

        CreateMap<UpdatePersonRequestModel, PersonUpdateUserRequest>();
        CreateMap<AddressRequestModel, AddressUpdateUserRequest>();
        CreateMap<PhoneNumberRequestModel, PhoneNumberUpdateUserRequest>();
        CreateMap<ParentRequestModel, ParentData>();

        CreateMap<ListUserIdsByFiltersRequestModel, ListUserIdsByFiltersRequest>();
        CreateMap<ListUserByFiltersRequestModel, ListUsersByFiltersRequest>();

    }

    private void ModelToDTO()
    {
        CreateMap<PersonRequestModel, PersonData>()
        .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => CommonHelper.ParseDateTime(src.BirthDate)))
        .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber));

        CreateMap<PhoneNumberRequestModel, PhoneNumberData>();
        CreateMap<ChangePasswordRequest, ChangePasswordData>();

        CreateMap<AddressRequestModel, AddressData>();
        CreateMap<ParentRequestModel, ParentData>();
    }

    private void RequestToDTO()
    {
        CreateMap<RegisterRequest, UserData>();
        CreateMap<RegisterByAgentRequest, UserData>();
        CreateMap<LoginRequest, LoginData>();
        CreateMap<UpdateUserRequest, UserDataToUpdate>();
        CreateMap<PersonUpdateUserRequest, PersonDataToUpdate>();
        CreateMap<AddressUpdateUserRequest, AddressDataToUpdate>();
        CreateMap<PhoneNumberUpdateUserRequest, PhoneNumberData>();
        CreateMap<GetUserRequest, UserData>();
        CreateMap<DeleteUserRequest, UserData>();
    }

    private void DTOToEntity()
    {
        CreateMap<UserData, User>();

        CreateMap<PersonData, Person>()
        .ForMember(dest => dest.BirthDate, opt => opt.MapFrom(src => CommonHelper.ParseDateTime(src.BirthDate)));

        CreateMap<AddressData, Address>();
        CreateMap<PhoneNumberData, PhoneNumber>();
        CreateMap<ParentData, Parent>();
    }

    private void EntityToDTO()
    {
        CreateMap<User, UserData>();
        CreateMap<Person, PersonData>();
        CreateMap<Parent, ParentData>();
        CreateMap<Gender, GenderData>();
        CreateMap<UserStatus, UserStatusData>();
        CreateMap<Address, AddressData>();
        CreateMap<PhoneNumber, PhoneNumberData>();
    }

    private void DTOToResponse()
    {
        CreateMap<UserData, GetUserResponse>();
        CreateMap<PersonData, GetUserPersonResponse>();
        CreateMap<PhoneNumberData, GetUserPersonPhoneNumberResponse>();
        CreateMap<AddressData, GetUserPersonAddressResponse>();
        CreateMap<GenderData, GenderResponse>();
        CreateMap<UserStatusData, UserStatusResponse>();
    }
}
