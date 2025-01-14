using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;
using MGP.Discapacidad.API.Controllers.SwaggerExample.Response;
using Microsoft.AspNetCore.Http;
using MGP.Discapacidad.API.Controllers.SwaggerExample.Response.Ticket;
using Asp.Versioning;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.API.Controllers.Swagger.Response;
using MGP.Discapacidad.API.Controllers.Swagger.Response.Ticket;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.List.ListTicketByAgent;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.CUD.Update;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.SUBE.Update;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.PARKING.Update;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;
using MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket.Request;
using MGP.Discapacidad.Application.UseCase.V1.Agent.Ticket.COUNT;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.AgentTicket;

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

    #region [POST] CREATE CUD 

    [MapToApiVersion("1.0")]
    [HttpPost("create-cud")]
    [SwaggerOperation(Summary = "Metodo de Generación de Ticket CUD", Description = "<strong>Esta funcionalidad permite a un agente crear un ticket CUD en el sistema para un usuario.</strong>  <br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(CreateTicketCudResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketCud([FromBody] CreateTicketCudAgentRequestModel request)
    {
        try
        {
            _logger.LogInformation($"Ticket");

            var createTicketRequest = _mapper.Map<CreateTicketCudRequest>(request);

            var result = await _mediator.Send(createTicketRequest);

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
                (int)Code.BAD_REQUEST => BadRequest(result),
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

    #region [GET] GET TICKET CUD
    [HttpGet("get-cud")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Obtención de Ticket", Description = "<strong> Este metodo devuelve la información completa de un Ticket de CUD a un Agente</strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetTicketCudResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetTicketCud([FromQuery] Guid ticketId, [FromQuery] string ticketCode)
    {
        try
        {
            _logger.LogInformation($"get-cud");

            GetTicketCudAgentRequest request = new()
            {
                TicketCode = ticketCode,
                TicketId = ticketId,
            };

            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [PUT] UPDATE TICKET CUD
    [HttpPut("update-cud")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Modificación de Ticket", Description = "<strong> Este metodo actualiza la información de un tramite CUD</strong>")]
    public async Task<IActionResult> UpdateTicketCud([FromBody] UpdateTicketCudRequestModel request)
    {
        try
        {
            _logger.LogInformation($"update-cud");

            var result = await _mediator.Send(_mapper.Map<UpdateTicketCudRequest>(request));

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [POST] Create Ticket SUBE
    [MapToApiVersion("1.0")]
    [HttpPost("create-sube")]
    [SwaggerOperation(Summary = "Metodo de Generación de Ticket SUBE", Description = "<strong>Esta funcionalidad permite a un agente crear un ticket de Sube para un vecino</strong> <br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketSube([FromBody] CreateTicketSubeAgentRequestModel request)
    {
        try
        {
            CreateTicketSubeRequest createTicketSubeRequest = _mapper.Map<CreateTicketSubeRequest>(request);

            var result = await _mediator.Send(createTicketSubeRequest);

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
                (int)Code.BAD_REQUEST => BadRequest(result),
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

    #region [GET] GET TICKET SUBE
    [HttpGet("get-sube")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Obtención de Ticket", Description = "<strong> Este metodo devuelve la información completa de un Ticket de Sube </strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetTicketSubeResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetSube([FromQuery] Guid ticketId, [FromQuery] string ticketCode)
    {
        try
        {
            _logger.LogInformation($"get-sube");

            GetTicketSubeAgentRequest request = new()
            {
                TicketId = ticketId,
                TicketCode = ticketCode
            };

            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [PUT] UPDATE TICKET SUBE
    [HttpPut("update-sube")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Modificación de Ticket", Description = "<strong> Este metodo actualiza la información de un tramite SUBE</strong>")]
    public async Task<IActionResult> UpdateTicketSube([FromBody] UpdateTicketSubeRequestModel request)
    {
        try
        {
            _logger.LogInformation($"update-sube");

            var result = await _mediator.Send(_mapper.Map<UpdateTicketSubeRequest>(request));

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [POST] Create Ticket Parking
    [MapToApiVersion("1.0")]
    [HttpPost("create-parking")]
    [SwaggerOperation(Summary = "Metodo de Generación de Ticket de Estacionamiento", Description = "<strong>Esta funcionalidad permite a un agente crear un ticket de parking para un usuario vecino</strong> <br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketParking([FromBody] CreateTicketParkingAgentRequestModel request)
    {
        try
        {
            CreateTicketParkingRequest createTicketParkingRequest = _mapper.Map<CreateTicketParkingRequest>(request);
            var result = await _mediator.Send(createTicketParkingRequest);

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
                (int)Code.BAD_REQUEST => BadRequest(result),
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

    #region [GET] GET TICKET PARKING

    [HttpGet("get-parking")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Obtención de Ticket", Description = "<strong> Este metodo devuelve la información completa de un Ticket de Estacionamiento</strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetTicketParkingResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetParkingByCode([FromQuery] Guid ticketId, [FromQuery] string ticketCode)
    {
        try
        {
            _logger.LogInformation($"get-parking");

            GetTicketParkingAgentRequest request = new()
            {
                TicketId = ticketId,
                TicketCode = ticketCode
            };

            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [PUT] UPDATE TICKET Parkign
    [HttpPut("update-parking")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Modificación de Ticket", Description = "<strong> Este metodo actualiza la información de un tramite Parking</strong>")]
    public async Task<IActionResult> UpdateTicketParking([FromBody] UpdateTicketParkingRequestModel request)
    {
        try
        {
            _logger.LogInformation($"update-sube");

            var result = await _mediator.Send(_mapper.Map<UpdateTicketParkingRequest>(request));

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [GET] LIST TICKET BY FILTERS
    [MapToApiVersion("1.0")]
    [HttpPost("list-tickets")]
    [SwaggerOperation(
        Summary = "Metodo que lista los tickets",
        Description = "<strong>Este endpoint recibe el Id del agente y lista todos los tickets asociados a un usuario.</strong>" +
        "<br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "Ok", typeof(ListTicketCudResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> ListTicketAgentByFilters([FromBody] ListTicketAgentRequestModel request)
    {
        try
        {
            _logger.LogInformation($"ListAgent");

            var result = await _mediator.Send(_mapper.Map<ListTicketAgentRequest>(request));

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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

    #region [GET] COUNT TICKET BY AGENT (STATUS)
    [MapToApiVersion("1.0")]
    [HttpGet("count-tickets")]
    [SwaggerOperation(Summary = "Metodo que realiza un conteo de los tickets por agente y su estado", Description = "<strong>Este metodo devuelve una lista con los agentes y la cantidad de tickets que tiene asignado por estado.</strong><br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CountTicketsByAgent()
    {
        try
        {
            _logger.LogInformation($"CountTickets");

            var result = await _mediator.Send(new CountTicketsByAgentRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
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
