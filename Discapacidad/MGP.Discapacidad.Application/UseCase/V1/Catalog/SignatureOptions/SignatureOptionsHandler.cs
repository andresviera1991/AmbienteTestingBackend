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
namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.SignatureOptions;

public class SignatureOptionsHandler : IRequestHandler<SignatureOptionsRequest, ResponseData<List<SignatureOptionsData>, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;
    public SignatureOptionsHandler(ICatalogService catalogService,
                                   MessageManager messageManager)
    {
        _catalogService = catalogService;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<List<SignatureOptionsData>, ResponseMessage>> Handle(SignatureOptionsRequest request, CancellationToken cancellationToken)
    {
        try
        {
            List<SignatureOptionsData> signatureOptionsData = await _catalogService.ListSignatureOptionsAsync();

            var responseData = new ResponseData<List<SignatureOptionsData>, ResponseMessage>(
               code: (int)Code.SUCCESS,
               data: signatureOptionsData,
               message: null);

            return await Task.FromResult(responseData);
        }

        catch (InvalidOperationException)
        {
            var responseData = new ResponseData<List<SignatureOptionsData>, ResponseMessage>(
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
