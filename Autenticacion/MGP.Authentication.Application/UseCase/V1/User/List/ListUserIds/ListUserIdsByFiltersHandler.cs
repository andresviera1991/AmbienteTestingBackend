
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

namespace MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;

public class ListUserIdsByFiltersHandler : IRequestHandler<ListUserIdsByFiltersRequest, ResponseData<List<Guid>, ResponseMessage>>
{
    private readonly IUserService _userService;
    private readonly IValidator<ListUserIdsByFiltersRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;


    public ListUserIdsByFiltersHandler(IUserService userService,
                           IValidator<ListUserIdsByFiltersRequest> validator,
                           IMapper mapper,
                           MessageManager messageManager)
    {
        _userService = userService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<List<Guid>, ResponseMessage>> Handle(ListUserIdsByFiltersRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            List<Guid> userData = await _userService.ListUserIdsByFilterAsync(request.FullName, request.DocumentNumber);

            var responseData = new ResponseData<List<Guid>, ResponseMessage>(
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
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]);
        }
    }
    private static async Task<ResponseData<List<Guid>, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<List<Guid>, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
