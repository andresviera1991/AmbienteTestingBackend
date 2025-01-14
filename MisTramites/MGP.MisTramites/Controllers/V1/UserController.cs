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
using MGP.MisTramites.Application.UseCase.V1.User.GetTicket;
using MGP.MisTramites.Application.UseCase.V1.User.ListTickets;

namespace MGP.MisTramites.API.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/user")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<UserController> _logger;
    private readonly IMapper _mapper;

    public UserController(IMediator mediator, ILogger<UserController> logger, IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region List "My Tickets"
    [HttpGet("list-tickets")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(Summary = "Metodo para listar todos los tickets de un usuario",Description = "<strong>Este método devuelve la lista de todos los tickets de un usuario en el sistema. <strong> ")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ListTicketResponseModel))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> ListTicketFromUser([FromHeader] Guid userId, [FromQuery] ListTicketUserFiltersRequestModel request)
    {
        try
        {
            _logger.LogInformation($"List Tickets");
            var listTicketUserRequest = _mapper.Map<ListTicketUserRequest>(request);

            listTicketUserRequest.UserId = userId;

            var result = await _mediator.Send(listTicketUserRequest);

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
    [SwaggerOperation(Summary = "Metodo de obtención de Tramite",Description = "<strong>Método que permite obtener el tramite, recibiendo el sistema, el tramite y el Id del ticket</strong>")]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(ResponseModel404))]
    public async Task<IActionResult> GetTicket([FromQuery] GetTicketRequestModel getTicketRequestModel, [FromHeader] Guid userId)
    {
        try
        {
            _logger.LogInformation($"GetTicket");
            var getTicketRequest = _mapper.Map<GetTicketUserRequest>(getTicketRequestModel);
            getTicketRequest.UserId = userId;
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
