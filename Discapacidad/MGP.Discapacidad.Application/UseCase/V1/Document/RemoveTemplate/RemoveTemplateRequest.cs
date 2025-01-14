using Flunt.Notifications;
using MediatR;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
using MGP.Discapacidad.CrossCutting.ResponseData;
using System;
namespace MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;
public class RemoveTemplateRequest : Notifiable, IRequest<ResponseData<RemoveTemplateResponse, ResponseMessage>>
{
    public Guid Id { get; set; }
}
