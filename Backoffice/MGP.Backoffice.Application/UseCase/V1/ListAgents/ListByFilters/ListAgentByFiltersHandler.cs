using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.Persistance.DTOs;

namespace MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;

public class ListAgentByFiltersHandler : IRequestHandler<ListAgentByFiltersRequest, ResponseData<ListAgentByFiltersListResponse, ResponseMessage>>
{
    private readonly IUserService _userService;
    private readonly IValidator<ListAgentByFiltersRequest> _validator;
    private readonly IMapper _mapper;
    private readonly MessageManager _messageManager;

    public ListAgentByFiltersHandler(IUserService userService,
                        IValidator<ListAgentByFiltersRequest> validator,
                        IMapper mapper,
                        MessageManager messageManager)

    {
        _userService = userService;
        _validator = validator;
        _mapper = mapper;
        _messageManager = messageManager;

    }

    public async Task<ResponseData<ListAgentByFiltersListResponse, ResponseMessage>> Handle(ListAgentByFiltersRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            var users = await _userService.ListAgentsByFilters(_mapper.Map<ListAgentByFiltersData>(request));

            var responseData = new ResponseData<ListAgentByFiltersListResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new ListAgentByFiltersListResponse() { Agents = _mapper.Map<List<ListAgentByFiltersResponse>>(users) },
                                   message: null
                                   );

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (AreaNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.AREA_NOT_FOUND)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<ListAgentByFiltersListResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<ListAgentByFiltersListResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}