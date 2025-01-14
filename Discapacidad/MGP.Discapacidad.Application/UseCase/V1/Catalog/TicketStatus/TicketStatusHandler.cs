using MediatR;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.TicketStatus;
public class TicketStatusHandler : IRequestHandler<TicketStatusRequest, ResponseData<List<TicketStatusData>, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public TicketStatusHandler(ICatalogService catalogService,
                               MessageManager messageManager)
    {
        _catalogService = catalogService;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<List<TicketStatusData>, ResponseMessage>> Handle(TicketStatusRequest request, CancellationToken cancellationToken)
    {
        try
        {
            List<TicketStatusData> ticketTypeData = await _catalogService.ListTicketStatusAsync();

            var responseData = new ResponseData<List<TicketStatusData>, ResponseMessage>(
               code: (int)Code.SUCCESS,
               data: ticketTypeData,
               message: null);

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            var responseData = new ResponseData<List<TicketStatusData>, ResponseMessage>(
               code: (int)Code.SERVICE_UNAVAILABLE,
               data: null,
               message: new ResponseMessage()
               {
                   Message = [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]
               });

            return await Task.FromResult(responseData);
        }
    }
}
