using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetAreas;
public class GetAreasHandler : IRequestHandler<GetAreasRequest, ResponseData<GetAreasResponse, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public GetAreasHandler(ICatalogService catalogService,
                        MessageManager messageManager)

    {
        _catalogService = catalogService;
        _messageManager = messageManager;

    }
    public async Task<ResponseData<GetAreasResponse, ResponseMessage>> Handle(GetAreasRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var responseData = new ResponseData<GetAreasResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new GetAreasResponse() { Areas = await _catalogService.GetAreasAsync()},
                                   message: null
                                   );

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<GetAreasResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<GetAreasResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
