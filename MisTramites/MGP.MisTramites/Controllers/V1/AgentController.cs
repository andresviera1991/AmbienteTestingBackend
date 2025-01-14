using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.MisTramites.CrossCutting.Helpers;
using MGP.Discapacidad.API.Controllers.V1.Ticket.Request;
using AutoMapper;
using Newtonsoft.Json;
using MGP.MisTramites.API.Controllers.Swagger.Response;
using MGP.MisTramites.API.Controllers.Swagger.Response.Ticket;
using MGP.MisTramites.Application.UseCase.V1.Agent.GetTicket;
using MGP.MisTramites.Application.UseCase.V1.Agent.ListTickets;

namespace MGP.MisTramites.API.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/agent")]
public class AgentController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<AgentController> _logger;
    private readonly IMapper _mapper;

    public AgentController(IMediator mediator,
                           ILogger<AgentController> logger,
                           IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region List "My Tickets"
    [HttpGet("list-tickets")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo para listar todos los tickets del sistema", Description = "<strong>Este método devuelve la lista de todos los tickets en el sistema. <strong> ")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ListTicketResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> ListTicketFromAgent([FromHeader] Guid employeeId, [FromQuery] ListTicketAgentFiltersRequestModel request)
    {
        try
        {
            _logger.LogInformation($"List Tickets Agent");
            var listRequest = _mapper.Map<ListTicketAgentRequest>(request);

            if (request.AssignedToMe)
            {
                listRequest.AgentId = employeeId;
            }

            var result = await _mediator.Send(listRequest);

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
            return StatusCode(500, new { Error = "An unexpected error occurred." });
        }
    }

    #endregion

    #region [GET] Get Tramite
    [MapToApiVersion("1.0")]
    [HttpGet("get-ticket")]
    [SwaggerOperation(Summary = "Metodo de obtención de Tramite", Description = "<strong>Método que permite obtener el tramite, recibiendo el sistema, el tramite y el Id del ticket</strong>")]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetTicket([FromQuery] GetTicketRequestModel getTicketRequestModel)
    {
        try
        {
            _logger.LogInformation($"GetTicket");
            var getTicketRequest = _mapper.Map<GetTicketAgentRequest>(getTicketRequestModel);
            var result = await _mediator.Send(getTicketRequest);

            return result.Code switch
            {
                (int)Code.Success => Ok(JsonConvert.SerializeObject(result, Formatting.Indented)),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
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
