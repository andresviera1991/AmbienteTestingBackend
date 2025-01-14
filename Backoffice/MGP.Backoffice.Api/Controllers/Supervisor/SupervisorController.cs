using Asp.Versioning;
using MGP.Backoffice.Application.UseCase.V1.GetAgent;
using MGP.Backoffice.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MediatR;
using Microsoft.Extensions.Logging;
using MGP.Backoffice.Api.Controllers.Supervisor.Response;

namespace MGP.Backoffice.Api.Controllers.Supervisor;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/supervisor")]
public class SupervisorController : ControllerBase
{

    private readonly IMediator _mediator;
    private readonly ILogger<SupervisorController> _logger;
    private const string InternalServerError = "An unexpected error occurred.";

    public SupervisorController(IMediator mediator, ILogger<SupervisorController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    #region [GET] Get Agent (SUPERVISOR)
    [MapToApiVersion("1.0")]
    [HttpGet("get-agent")]
    [SwaggerOperation(Summary = "Metodo para obtener la información de un agente.", Description = "<strong>Este endpoint permite obtener los datos de un agente por su Id</strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(GetAgentResponseModelExample))]
    public async Task<IActionResult> GetAgentById([FromQuery] Guid employeeId)
    {
        try
        {
            _logger.LogInformation("Get Agent");
            var result = await _mediator.Send(new GetAgentRequest() { AgentId = employeeId });

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
                _ => StatusCode(StatusCodes.Status503ServiceUnavailable, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = InternalServerError });
        }
    }
    #endregion
}
