
using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;

public class ListUsersByFiltersHandler : IRequestHandler<ListUsersByFiltersRequest, ResponseData<ListUsersByFiltersResponse, ResponseMessage>>
{
    private readonly IUserService _userService;
    private readonly IValidator<ListUsersByFiltersRequest> _validator;
    private readonly MessageManager _messageManager;


    public ListUsersByFiltersHandler(IUserService userService,
                           IValidator<ListUsersByFiltersRequest> validator,
                           MessageManager messageManager)
    {
        _userService = userService;
        _validator = validator;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<ListUsersByFiltersResponse, ResponseMessage>> Handle(ListUsersByFiltersRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            var response = new ListUsersByFiltersResponse() { Users = await _userService.ListUsersByFilterAsync(request.FullName, request.DocumentNumber, request.PageSize, request.PageNumber) };

            var responseData = new ResponseData<ListUsersByFiltersResponse, ResponseMessage>(
                               code: (int)Code.Success,
                               data: response,
                               message: null
                               );

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }
    private static async Task<ResponseData<ListUsersByFiltersResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<ListUsersByFiltersResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
