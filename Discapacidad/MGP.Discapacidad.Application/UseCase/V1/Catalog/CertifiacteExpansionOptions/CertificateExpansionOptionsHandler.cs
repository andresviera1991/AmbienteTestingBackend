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
namespace MGP.Discapacidad.Application.UseCase.V1.Catalog.CertifiacteExpansionOptions;

public class CertificateExpansionOptionsHandler : IRequestHandler<CertificateExpansionOptionsRequest, ResponseData<List<CertificateExpansionOptionsData>, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public CertificateExpansionOptionsHandler(ICatalogService catalogService,
                                              MessageManager messageManager)
    {
        _catalogService = catalogService;
        _messageManager = messageManager;
    }

    public async Task<ResponseData<List<CertificateExpansionOptionsData>, ResponseMessage>> Handle(CertificateExpansionOptionsRequest request, CancellationToken cancellationToken)
    {
        try
        {
            List<CertificateExpansionOptionsData> expansionOptionsData = await _catalogService.ListCertificateExpansionOptionsAsync();


            var responseData = new ResponseData<List<CertificateExpansionOptionsData>, ResponseMessage>(
                code: (int)Code.SUCCESS,
                data: expansionOptionsData,
                message: null);

            return await Task.FromResult(responseData);

        }
        catch (Exception)
        {
            var responseData = new ResponseData<List<CertificateExpansionOptionsData>, ResponseMessage>(
                code: (int)Code.SERVICE_UNAVAILABLE,
                data: null,
                message: new ResponseMessage()
                {
                    Message = new List<string>
                    {
                        _messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)
                    }
                }
            );
            return await Task.FromResult(responseData);
        }
    }
}
