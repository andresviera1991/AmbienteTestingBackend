using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.CrossCutting.ResponseData;
using System.Collections.Generic;
using MGP.Authentication.CrossCutting.Helpers;
using Microsoft.EntityFrameworkCore;
using MGP.Authentication.CrossCutting.Exceptions;
using System.Linq;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using MGP.Authentication.CrossCutting.MessagesManager;
namespace MGP.Authentication.Application.UseCase.V1.User.GetUser;

public class GetUserHandler : IRequestHandler<GetUserRequest, ResponseData<GetUserResponse, ResponseMessage>>
{
    private readonly IUserService _userService;
    private readonly IValidator<GetUserRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;


    public GetUserHandler(IUserService userService,
                           IValidator<GetUserRequest> validator,
                           IMapper mapper,
                           MessageManager messageManager)
    {
        _userService = userService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<GetUserResponse, ResponseMessage>> Handle(GetUserRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            var userDataRequest = _mapper.Map<UserData>(request);
            userDataRequest.Id = request.UserId;
            UserData userData = await _userService.GetUserByIdAsync(userDataRequest.Id);

            var responseData = new ResponseData<GetUserResponse, ResponseMessage>(
                               code: (int)Code.Success,
                               data: _mapper.Map<GetUserResponse>(userData),
                               message: null
                               );

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (DbUpdateException)
        {
            return await HandleException(Code.Conflict, [_messageManager.GetNotification(FunctionalMessages.USER_NOT_EXISTS)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }

    }
    private static async Task<ResponseData<GetUserResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<GetUserResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
