using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MediatR;
using Asp.Versioning;
using MGP.Audit.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using MGP.Audit.Application.UseCase.V1.Audit.GetAuditList;

namespace MGP.Audit.API.Controllers.V1.Audit
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/audit")]
    public class AuditController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuditController(IMediator mediator) { _mediator = mediator; }

        #region Document Type Options

        [HttpGet("audit")]
        [MapToApiVersion("1.0")]
        [SwaggerOperation(
            Summary = "Listar auditorias",
           Description = "<strong>Este método devuelve la lista de auditorias <strong> "

        )]
        public async Task<IActionResult> GetAudit()
        {
            try
            {
                var result = await _mediator.Send(new GetAuditListRequest());

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
