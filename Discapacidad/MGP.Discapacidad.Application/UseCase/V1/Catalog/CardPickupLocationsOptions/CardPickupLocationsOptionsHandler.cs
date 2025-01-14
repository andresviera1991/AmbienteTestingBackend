using MediatR;
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

namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.CardPickupLocationsOptions;

public class CardPickupLocationsOptionsHandler : IRequestHandler<CardPickupLocationsOptionsRequest, ResponseData<List<CardPickupLocationsOptionsData>, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public CardPickupLocationsOptionsHandler(ICatalogService catalogService,
                                             MessageManager messageManager)
    {
        _catalogService = catalogService;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<List<CardPickupLocationsOptionsData>, ResponseMessage>> Handle(CardPickupLocationsOptionsRequest request, CancellationToken cancellationToken)
    {
        try
        {
            List<CardPickupLocationsOptionsData> cardPickupLocationsOptions = await _catalogService.ListCardPickupLocationsOptionsAsync();

            var responseData = new ResponseData<List<CardPickupLocationsOptionsData>, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: cardPickupLocationsOptions,
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (Exception)
        {
            var responseData = new ResponseData<List<CardPickupLocationsOptionsData>, ResponseMessage>(
                code: (int)Code.SERVICE_UNAVAILABLE,
                data: null,
                message: new ResponseMessage()
                {
                    Message = [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]
                }
            );
            return await Task.FromResult(responseData);
        }
    }
}
