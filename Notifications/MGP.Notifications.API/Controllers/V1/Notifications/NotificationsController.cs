using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MediatR;
using Asp.Versioning;
using MGP.Notifications.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using MGP.Notifications.Application.UseCase.V1.Notifications.GetNotificationsList;

namespace MGP.Notifications.API.Controllers.V1.Notifications
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/Notifications")]
    public class NotificationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotificationsController(IMediator mediator) { _mediator = mediator; }

        #region Notification List

        [HttpGet("Notifications")]
        [MapToApiVersion("1.0")]
        [SwaggerOperation(
            Summary = "Listar Notificaciones",
           Description = "<strong>Este método devuelve la lista de Notificaciones <strong> "

        )]
        public async Task<IActionResult> GetNotifications()
        {
            try
            {
                var result = await _mediator.Send(new GetNotificationsListRequest());

                return result.Code switch
                {
                    (int)Code.Success => Ok(result),
                    (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
                    _ => StatusCode(StatusCodes.Status503ServiceUnavailable, result)
                };
            }
            catch (Exception)
            {
                return StatusCode(500, new { Error = "An unexpected error occurred." });
            }
        }

        #endregion

    }
}
