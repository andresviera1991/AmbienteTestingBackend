using Asp.Versioning;
using AutoMapper;
using MediatR;
using MGP.Discapacidad.API.Controllers.SwaggerExample.Response;
using MGP.Discapacidad.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.Discapacidad.API.Controllers.V1.Ticket.SupervisorTicket.Request;
using MGP.Discapacidad.Application.UseCase.V1.Supervisor.ReassignTicket;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.SupervisorTicket;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/supervisor")]
public class SupervisorController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<SupervisorController> _logger;
    private readonly IMapper _mapper;

    public SupervisorController(IMediator mediator,
                            ILogger<SupervisorController> logger,
                            IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region [POST] REASSIGN TICKET
    [MapToApiVersion("1.0")]
    [HttpPost("reassign-ticket")]
    [SwaggerOperation(
       Summary = "Metodo de Reasignación de Ticket",Description = "<strong>Esta funcionalidad oermite a un supervisor reasignar un ticket.</strong><br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(ReassignTicketRequestModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketCud([FromBody] ReassignTicketRequestModel request,[FromHeader] Guid employeeId)
    {
        try
        {
            _logger.LogInformation($"reassign ticket");
            var reassignTicketRequest = _mapper.Map<ReassignTicketRequest>(request);
            reassignTicketRequest.SupervisorId = employeeId;
            var result = await _mediator.Send(reassignTicketRequest);

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
                (int)Code.CONFLICT => Conflict(result),
                (int)Code.SERVICE_UNAVAILABLE => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
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
