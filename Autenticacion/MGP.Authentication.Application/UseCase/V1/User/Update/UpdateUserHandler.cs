using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.CrossCutting.ResponseData;
using System.Collections.Generic;
using MGP.Authentication.CrossCutting.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using MGP.Authentication.CrossCutting.Exceptions;
using System.Linq;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MGP.Authentication.CrossCutting.MessagesManager;

namespace MGP.Authentication.Application.UseCase.V1.User.Update;

public class UpdateUserHandler : IRequestHandler<UpdateUserRequest, ResponseData<UserData, ResponseMessage>>
{
    private readonly IUserService _userService;
    private readonly IValidator<UpdateUserRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;


    public UpdateUserHandler(IUserService userService,
                           IValidator<UpdateUserRequest> validator,
                           IMapper mapper,
                           MessageManager messageManager)
    {
        _userService = userService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<UserData, ResponseMessage>> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            var userDataRequest = _mapper.Map<UserDataToUpdate>(request);
            userDataRequest.Id = request.UserId.Value;
            UserData userData = await _userService.PatchUserAsync(userDataRequest);

            var responseData = new ResponseData<UserData, ResponseMessage>(
                               code: (int)Code.Success,
                               data: userData,
                               message: null
                               );

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (DocumentNumberException)
        {
            return await HandleException(Code.Conflict, [_messageManager.GetNotification(FunctionalMessages.DOCUMENT_NUMBER_ERROR)]);
        }
        catch (NotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalMessages.USER_NOT_EXISTS)]);
        }
        catch (DbUpdateException)
        {
            return await HandleException(Code.Conflict, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<UserData, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<UserData, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
