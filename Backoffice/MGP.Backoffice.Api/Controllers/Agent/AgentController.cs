using Asp.Versioning;
using AutoMapper;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;
using MGP.Backoffice.Application.UseCase.V1.GetAgent;
using MGP.Backoffice.Api.Controllers.Agent.Request;
using MGP.Backoffice.Application.UseCase.V1.AddAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.GetAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.UpdateAgentLeave;
using MGP.Backoffice.Application.UseCase.V1.NextAvailableAgent;
using MGP.Backoffice.Application.UseCase.V1.UpdateAgent;
using MGP.Backoffice.Api.Controllers.Agent.Request.Update;
using MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByFilters;
using MGP.Backoffice.Application.UseCase.V1.ListAgents.ListByTicketType;

namespace MGP.Backoffice.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/agent")]
public class AgentController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<AgentController> _logger;
    private readonly IMapper _mapper;
    private const string InternalServerError = "An unexpected error occurred.";

    public AgentController(IMediator mediator,
                          ILogger<AgentController> logger,
                          IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region [GET] Get Agent
    [MapToApiVersion("1.0")]
    [HttpGet("get")]
    [SwaggerOperation(
        Summary = "Metodo para obtener la información de un agente.",
        Description = "<strong>Este endpoint permite obtener los datos de un agente por su Id</strong>")]
    public async Task<IActionResult> GetAgentById([FromHeader] Guid employeeId)
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

    #region [GET] List Agent By Filters
    [MapToApiVersion("1.0")]
    [HttpGet("list-by-filters")]
    [SwaggerOperation(Summary = "Metodo para obtener una lista de agentes por filtro y paginado", Description = "<strong>Este endpoint permite obtener una lista de agentes por filtros como area, rol y estado.</strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para obtener los agentes.</em>")]
    public async Task<IActionResult> ListAgentByFilters([FromQuery] ListAgentByFiltersRequestModel listAgentByFilters)
    {
        try
        {
            _logger.LogInformation("List Agent");

            var result = await _mediator.Send(_mapper.Map<ListAgentByFiltersRequest>(listAgentByFilters));

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

    #region LIST AGENT BY TICKET TYPE
    [MapToApiVersion("1.0")]
    [HttpGet("list-by-ticket-type-id")]
    [SwaggerOperation(Summary = "Metodo para obtener una lista de agentes por filtro y paginado", Description = "<strong>Este endpoint permite obtener una lista de agentes por filtros como area, rol y estado.</strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para obtener los agentes.</em>")]
    public async Task<IActionResult> ListAgentByTicketTypeId(int? ticketTypeId)
    {
        try
        {
            _logger.LogInformation("List Agent");

            var result = await _mediator.Send(new ListAgentByTicketTypeRequest() { TicketTypeId = ticketTypeId} );

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

    #region [PUT] Update Agent
    [MapToApiVersion("1.0")]
    [HttpPut("update")]
    [SwaggerOperation(
        Summary = "Metodo para modificar la información de un agente.",
        Description = "<strong>Este endpoint permite modificar los datos de un agente</strong>")]
    public async Task<IActionResult> UpdateAgent(UpdateAgentRequestModel request)
    {
        try
        {
            _logger.LogInformation("Update Agent");
            var updateAgentRequest = _mapper.Map<UpdateAgentRequest>(request);
            var result = await _mediator.Send(updateAgentRequest);

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

    #region [POST] Add Leave
    [MapToApiVersion("1.0")]
    [HttpPost("add-leave")]
    [SwaggerOperation(Summary = "Metodo para cargar la licencia de un agente",Description = "<strong>Este endpoint permite cargarle licencia a un agente </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para agregar licencia.</em>")]
    public async Task<IActionResult> AddLeave([FromHeader]Guid employeeId, [FromBody] AddAgentLeaveRequestModel addAgentLeaveRequestModel)
    {
        try
        {
            _logger.LogInformation("Add Agent Leave");
            var request = _mapper.Map<AddAgentLeaveRequest>(addAgentLeaveRequestModel);
            request.AgentId = employeeId;
            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.Created => Created("", result),
                (int)Code.BadRequest => BadRequest(result),
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

    #region [GET] List AgentLeave By AgentId
    [MapToApiVersion("1.0")]
    [HttpGet("list-agent-leave")]
    [SwaggerOperation(
        Summary = "Metodo para obtener las licencias de un agente",
        Description = "<strong>Este endpoint permite obtener las licencias de un agente </strong>" +
        "<br><br> <em>A continuación se detalla el ejemplo de una solicitud para obtener las licencias.</em>")]
    public async Task<IActionResult> GetAgentLeave([FromHeader] Guid employeeId)
    {
        try
        {
            _logger.LogInformation("List Agent");
            var result = await _mediator.Send(new GetAgentLeaveRequest() { AgentId = employeeId});

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

    #region [PATCH] Patch Leave
    [MapToApiVersion("1.0")]
    [HttpPatch("agent-leave")]
    [SwaggerOperation(Summary = "Metodo para modificar la licencia de un agente",Description = "<strong>Este endpoint permite modificarle la licencia a un agente </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para modificar licencia.</em>")]
    public async Task<IActionResult> UpdateLeave([FromHeader] Guid employeeId, [FromBody] UpdateAgentLeaveRequestModel updateAgentLeaveRequestModel)
    {
        try
        {
            _logger.LogInformation("Update Agent Leave");
            var request = _mapper.Map<UpdateAgentLeaveRequest>(updateAgentLeaveRequestModel);
            request.AgentId = employeeId;
            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
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

    #region [GET] Get Agent Next Available
    [MapToApiVersion("1.0")]
    [HttpGet("next-available-agent")]
    public async Task<IActionResult> GetNextAvailableAgent([FromQuery]NextAvailableAgentRequestModel request)
    {
        try
        {
            _logger.LogInformation("GetNextAvailableAgent");

            var result = await _mediator.Send(_mapper.Map<NextAvailableAgentRequest>(request));

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
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
