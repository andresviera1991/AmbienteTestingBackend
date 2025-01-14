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
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.CUD.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.List.ListTicketByUser;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.PARKING.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Create;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.SUBE.Get;
using MGP.Discapacidad.Application.UseCase.V1.User.Ticket.Update;
using MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket.Request;

namespace MGP.Discapacidad.API.Controllers.V1.Ticket.UserTicket;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/ticket")]
public class TicketController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<TicketController> _logger;
    private readonly IMapper _mapper;

    public TicketController(IMediator mediator, ILogger<TicketController> logger, IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region [POST] Create Ticket CUD
    [MapToApiVersion("1.0")]
    [HttpPost("create-cud")]
    [SwaggerOperation(
        Summary = "Metodo de Generación de Ticket CUD",
        Description = "<strong>Esta funcionalidad crea un nuevo Ticket en el sistema para realizar el tramite de CUD</strong>" +
        "<br> <em>A continuación se detalla un ejemplo</em>"
    )]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(CreateTicketCudResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketCud([FromBody] CreateTicketCudRequestModel request,
                                                     [FromHeader] Guid userId,
                                                     [FromHeader] string userEmail)
    {
        try
        {
            _logger.LogInformation($"Ticket");

            var createTicketRequest = _mapper.Map<CreateTicketCudRequest>(request);
            createTicketRequest.UserId = userId;
            createTicketRequest.Email = userEmail;

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
    [SwaggerOperation(Summary = "Metodo de Obtención de Ticket", Description = "<strong> Este metodo devuelve la información completa de un Ticket de CUD</strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetTicketCudResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetTicketCud([FromHeader] Guid userId, [FromQuery] Guid ticketId, [FromQuery] string ticketCode)
    {
        try
        {
            _logger.LogInformation($"get-cud");

            GetTicketCudUserRequest request = new()
            {
                UserId = userId,
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

    #region [POST] Create Ticket SUBE
    [MapToApiVersion("1.0")]
    [HttpPost("create-sube")]
    [SwaggerOperation(
        Summary = "Metodo de Generación de Ticket SUBE",
        Description = "<strong>Esta funcionalidad crea un nuevo Ticket en el sistema para realizar el tramite de Tarjeta Sube</strong>" +
        "<br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketSube([FromBody] CreateTicketSubeRequestModel request,
                                                      [FromHeader] Guid userId,
                                                      [FromHeader] string userEmail)
    {
        try
        {
            CreateTicketSubeRequest createTicketSubeRequest = _mapper.Map<CreateTicketSubeRequest>(request);
            createTicketSubeRequest.Email = userEmail;
            createTicketSubeRequest.UserId = userId;

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

    #region [GET] Get Ticket Sube
    [HttpGet("get-sube")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Obtención de Ticket", Description = "<strong> Este metodo devuelve la información completa de un Ticket de Sube </strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetTicketSubeResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetSube([FromHeader] Guid userId, [FromQuery] Guid ticketId, [FromQuery] string ticketCode)
    {
        try
        {
            _logger.LogInformation($"get-sube");

            GetTicketSubeUserRequest request = new()
            {
                UserId = userId,
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

    #region [POST] Create Ticket Parking
    [MapToApiVersion("1.0")]
    [HttpPost("create-parking")]
    [SwaggerOperation(
        Summary = "Metodo de Generación de Ticket de Estacionamiento",
        Description = "<strong>Esta funcionalidad crea un nuevo Ticket en el sistema para realizar el tramite de Estacionamiento</strong>" +
        "<br> <em>A continuación se detalla un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> CreateTicketParking([FromBody] CreateTicketParkingRequestModel request,
                                                         [FromHeader] Guid userId,
                                                         [FromHeader] string userEmail)
    {
        try
        {
            CreateTicketParkingRequest createTicketParkingRequest = _mapper.Map<CreateTicketParkingRequest>(request);
            createTicketParkingRequest.Email = userEmail;
            createTicketParkingRequest.UserId = userId;

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

    #region [GET] Get Ticket Parking

    [HttpGet("get-parking")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de Obtención de Ticket", Description = "<strong> Este metodo devuelve la información completa de un Ticket de Estacionamiento</strong>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetTicketParkingResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetParkingByCode([FromHeader] Guid userId, [FromQuery] Guid ticketId, [FromQuery] string ticketCode)
    {
        try
        {
            _logger.LogInformation($"get-parking");

            GetTicketParkingUserRequest request = new()
            {
                UserId = userId,
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

    #region [GET] List Ticket
    [MapToApiVersion("1.0")]
    [HttpGet("list")]
    [SwaggerOperation(
        Summary = "Metodo que lista los tickets",
        Description = "<strong>Este endpoint recibe el Id del usuario y lista todos los tickets asociados a un usuario.</strong>" +
        "<br> <em>A continuación se detalla un ejemplo</em>"

    )]
    [SwaggerResponse(StatusCodes.Status200OK, "Ok", typeof(ListTicketCudResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> ListTicket([FromHeader] Guid userId)
    {
        try
        {
            _logger.LogInformation($"ListByIdPerson");
            ListTicketUserRequest listTicketRequest = new() { UserId = userId };
            var result = await _mediator.Send(listTicketRequest);

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
                (int)Code.BAD_REQUEST => BadRequest(result),
                (int)Code.NOT_FOUND => NotFound(result),
                (int)Code.SERVICE_UNAVAILABLE => StatusCode(StatusCodes.Status500InternalServerError, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = "An unexpected error occurred." });
        }
    }
    #endregion

    #region [POST] CANCEL TICKET
    [HttpPost("cancel")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo de cancelación de Ticket", Description = "<strong> Este método cancela un ticket asociado a un usuario (sea de CUD SUBE O PARKING)</strong>")]
    public async Task<IActionResult> CancelTicket([FromHeader] Guid userId, [FromQuery] Guid ticketId)
    {
        try
        {
            _logger.LogInformation($"cancel-ticket");

            CancelTicketRequest request = new()
            {
                UserId = userId,
                TicketId = ticketId
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

}
