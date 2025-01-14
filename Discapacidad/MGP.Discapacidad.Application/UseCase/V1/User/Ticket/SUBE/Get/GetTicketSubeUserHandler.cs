using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using System.Linq;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using MGP.Discapacidad.Persistance.DTOs.Ticket;

namespace MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;

public class GetTicketSubeUserHandler : IRequestHandler<GetTicketSubeUserRequest, ResponseData<GetTicketSubeData, ResponseMessage>>

{
    private readonly ITicketService _TicketService;
    private readonly IValidator<GetTicketSubeUserRequest> _validator;
    private readonly MessageManager _messageManager;
    private readonly IMapper _mapper;

    public GetTicketSubeUserHandler(ITicketService TicketService,
                                IValidator<GetTicketSubeUserRequest> validator,
                                MessageManager messageManager,
                                IMapper mapper)
    {
        _TicketService = TicketService;
        _validator = validator;
        _messageManager = messageManager;
        _mapper = mapper;
    }

    public async Task<ResponseData<GetTicketSubeData, ResponseMessage>> Handle(GetTicketSubeUserRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            GetTicketSubeData getTicketResponse = _mapper.Map<GetTicketSubeData>(await _TicketService.GetTicketSubeUserAsync(request.UserId, request.TicketId, request.TicketCode));

            var responseData = new ResponseData<GetTicketSubeData, ResponseMessage>(
                       code: (int)Code.SUCCESS,
                       data: getTicketResponse,
                       message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BAD_REQUEST, e.Errors);
        }
        catch (TicketNotFoundException)
        {
            return await HandleException(Code.NOT_FOUND, [_messageManager.GetNotification(FunctionalMessages.TICKET_NOT_FOUND)], null);
        }
        catch (Exception)
        {
            return await HandleException(Code.SERVICE_UNAVAILABLE, [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)], null);
        }
    }

    private static async Task<ResponseData<GetTicketSubeData, ResponseMessage>> HandleException(Code errorCode, List<string> message, GetTicketSubeData response = null)
    {
        var responseData = new ResponseData<GetTicketSubeData, ResponseMessage>(
                           code: (int)errorCode,
                           data: response,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
