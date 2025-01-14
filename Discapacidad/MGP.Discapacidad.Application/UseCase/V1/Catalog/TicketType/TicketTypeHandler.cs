using MediatR;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.Type;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.CrossCutting.Messages;
using MGP.Discapacidad.CrossCutting.MessagesManager;
using MGP.Discapacidad.CrossCutting.ResponseData;
using MGP.Discapacidad.Domain.interfaces;
using MGP.Discapacidad.Persistance.DTOs.Catalog;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.TicketType;
public class TicketTypeHandler : IRequestHandler<TicketTypeRequest, ResponseData<List<TicketTypeData>, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public TicketTypeHandler(ICatalogService catalogService,
                             MessageManager messageManager)
    {
        _catalogService = catalogService;
        _messageManager = messageManager;
    }
    public async Task<ResponseData<List<TicketTypeData>, ResponseMessage>> Handle(TicketTypeRequest request, CancellationToken cancellationToken)
    {
        try
        {
            List<TicketTypeData> ticketTypeData = await _catalogService.ListTicketTypeAsync();

            var responseData = new ResponseData<List<TicketTypeData>, ResponseMessage>(
               code: (int)Code.SUCCESS,
               data: ticketTypeData,
               message: null);

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            var responseData = new ResponseData<List<TicketTypeData>, ResponseMessage>(
               code: (int)Code.SERVICE_UNAVAILABLE,
               data: null,
               message: new ResponseMessage()
               {
                   Message = new List<string>
                   {
                       _messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)
                   }
               });

            return await Task.FromResult(responseData);
        }
    }
}
