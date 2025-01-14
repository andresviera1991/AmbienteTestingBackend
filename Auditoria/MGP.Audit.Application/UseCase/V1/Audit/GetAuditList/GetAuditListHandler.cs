using MediatR;
using MGP.Audit.CrossCutting.Helpers;
using MGP.Audit.CrossCutting.Messages;
using MGP.Audit.CrossCutting.MessagesManager;
using MGP.Audit.CrossCutting.ResponseData;
using MGP.Audit.Domain.interfaces;
using MGP.Audit.Persistance.DTOs.Audit;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Audit.Application.UseCase.V1.Audit.GetAuditList
{
    public class AuditHandler : IRequestHandler<GetAuditListRequest, ResponseData<List<AuditData>, ResponseMessage>>
    {
        private readonly IAuditService _catalogService;
        private readonly MessageManager _messageManager;

        public AuditHandler(
            IAuditService catalogService,
            MessageManager messageManager)
        {
            _catalogService = catalogService;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<List<AuditData>, ResponseMessage>> Handle(GetAuditListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                List<AuditData> AuditData = await _catalogService.ListAuditAsync();

                var responseData = new ResponseData<List<AuditData>, ResponseMessage>(
                    code: (int)Code.Success,
                    data: AuditData,
                    message: null);

                return await Task.FromResult(responseData);

            }
            catch (InvalidOperationException)
            {

                var responseData = new ResponseData<List<AuditData>, ResponseMessage>(
                    code: (int)Code.ServiceUnavailable,
                    data: null,
                    message: new ResponseMessage()
                    {
                        Message = new List<string>
                        {
                            _messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)
                        }
                    }
                );
                return await Task.FromResult(responseData);
            }
        }
    }
}
