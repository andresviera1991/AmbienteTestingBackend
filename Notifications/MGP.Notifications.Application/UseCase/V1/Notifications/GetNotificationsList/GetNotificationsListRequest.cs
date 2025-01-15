using Flunt.Notifications;
using MediatR;
using MGP.Notifications.CrossCutting.ResponseData;
using MGP.Notifications.Persistance.DTOs.Notifications;
using System.Collections.Generic;

namespace MGP.Notifications.Application.UseCase.V1.Notifications.GetNotificationsList
{
    public class GetNotificationsListRequest : Notifiable, IRequest<ResponseData<List<NotificationData>, ResponseMessage>>
    {
    }
}
