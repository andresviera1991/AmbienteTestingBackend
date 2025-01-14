using Flunt.Notifications;
using MediatR;
using MGP.Audit.CrossCutting.ResponseData;
using MGP.Audit.Persistance.DTOs.Audit;
using System.Collections.Generic;

namespace MGP.Audit.Application.UseCase.V1.Audit.GetAuditList
{
    public class GetAuditListRequest : Notifiable, IRequest<ResponseData<List<AuditData>, ResponseMessage>>
    {
    }
}
