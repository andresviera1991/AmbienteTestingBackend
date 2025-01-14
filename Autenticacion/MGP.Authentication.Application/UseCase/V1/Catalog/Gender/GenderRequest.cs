using Flunt.Notifications;
using MediatR;
using MGP.Authentication.CrossCutting.ResponseData;
using System.Collections.Generic;

namespace MGP.Authentication.Application.UseCase.V1.Catalog.Gender
{
    public class GenderRequest : Notifiable, IRequest<ResponseData<List<GenderResponse>, ResponseMessage>>
    {
    }
}
