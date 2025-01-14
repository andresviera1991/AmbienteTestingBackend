using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;
public class UpdateTemplateRequest : Notifiable, IRequest<ResponseData<UpdateTemplateResponse, ResponseMessage>>
{
    public Guid Id { get; set; }
    public int TicketTypeId { get; set; }
    public string Name { get; set; }
    public string Information { get; set; }
    public bool? Status { get; set; }
}
