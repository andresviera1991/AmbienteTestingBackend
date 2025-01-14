using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetTicketByArea;
public class GetTicketByAreaHandler : IRequestHandler<GetTicketByAreaRequest, ResponseData<GetTicketByAreaResponse, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public GetTicketByAreaHandler(ICatalogService catalogService,
                        MessageManager messageManager)

    {
        _catalogService = catalogService;
        _messageManager = messageManager;

    }
    public async Task<ResponseData<GetTicketByAreaResponse, ResponseMessage>> Handle(GetTicketByAreaRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var responseData = new ResponseData<GetTicketByAreaResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new GetTicketByAreaResponse() { TicketTypes = await _catalogService.GetTicketByAreaAsync(request.Area)},
                                   message: null
                                   );

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<GetTicketByAreaResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<GetTicketByAreaResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
