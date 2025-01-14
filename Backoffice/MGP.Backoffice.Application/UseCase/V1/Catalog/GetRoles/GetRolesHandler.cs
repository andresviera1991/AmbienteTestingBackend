using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.Catalog.GetRoles;
public class GetRolesHandler : IRequestHandler<GetRolesRequest, ResponseData<GetRolesResponse, ResponseMessage>>
{
    private readonly ICatalogService _catalogService;
    private readonly MessageManager _messageManager;

    public GetRolesHandler(ICatalogService catalogService,
                        MessageManager messageManager)

    {
        _catalogService = catalogService;
        _messageManager = messageManager;

    }
    public async Task<ResponseData<GetRolesResponse, ResponseMessage>> Handle(GetRolesRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var responseData = new ResponseData<GetRolesResponse, ResponseMessage>(
                                   code: (int)Code.Success,
                                   data: new GetRolesResponse() { Roles = await _catalogService.GetRolesAsync()},
                                   message: null
                                   );

            return await Task.FromResult(responseData);
        }
        catch (Exception)
        {
            return await HandleException(Code.ServiceUnavailable, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<GetRolesResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<GetRolesResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
