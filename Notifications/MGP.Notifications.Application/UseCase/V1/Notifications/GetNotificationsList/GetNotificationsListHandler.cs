using MediatR;
using MGP.Notifications.CrossCutting.Helpers;
using MGP.Notifications.CrossCutting.Messages;
using MGP.Notifications.CrossCutting.MessagesManager;
using MGP.Notifications.CrossCutting.ResponseData;
using MGP.Notifications.Domain.interfaces;
using MGP.Notifications.Persistance.DTOs.Notifications;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Notifications.Application.UseCase.V1.Notifications.GetNotificationsList
{
    public class GetNotificationsListHandler : IRequestHandler<GetNotificationsListRequest, ResponseData<List<NotificationData>, ResponseMessage>>
    {
        private readonly INotificationsService _notificationsService;
        private readonly MessageManager _messageManager;

        public GetNotificationsListHandler(
            INotificationsService notificationsService,
            MessageManager messageManager)
        {
            _notificationsService = notificationsService;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<List<NotificationData>, ResponseMessage>> Handle(GetNotificationsListRequest request, CancellationToken cancellationToken)
        {
            try
            {
                List<NotificationData> NotificationsData = await _notificationsService.ListNotificationsAsync();

                var responseData = new ResponseData<List<NotificationData>, ResponseMessage>(
                    code: (int)Code.Success,
                    data: NotificationsData,
                    message: null);

                return await Task.FromResult(responseData);

            }
            catch (InvalidOperationException)
            {

                var responseData = new ResponseData<List<NotificationData>, ResponseMessage>(
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
