using Asp.Versioning;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.Backoffice.Application.UseCase.V1.Catalog.GetRoles;
using MGP.Backoffice.Application.UseCase.V1.Catalog.GetAreas;
using MGP.Backoffice.Application.UseCase.V1.Catalog.GetTicketByArea;
using MGP.Backoffice.Application.UseCase.V1.Catalog.ListUserStatus;
using MGP.Backoffice.Api.Controllers.Catalog.Response;
namespace MGP.Backoffice.Api.Controllers.Catalog;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/catalog")]
public class CatalogController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<CatalogController> _logger;
    private const string InternalServerError = "An unexpected error occurred.";


    public CatalogController(IMediator mediator,
                          ILogger<CatalogController> logger)
    {
        _mediator = mediator;
        _logger = logger;
    }

    #region [GET] Get Roles
    [MapToApiVersion("1.0")]
    [HttpGet("roles")]
    [SwaggerOperation(Summary = "Metodo que lista los roles existentes")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(GetRolesResponseModelExample))]
    public async Task<IActionResult> GetRoles()
    {
        try
        {
            _logger.LogInformation("GetRoles");

            var result = await _mediator.Send(new GetRolesRequest());

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

    #region [GET] Get Areas
    [MapToApiVersion("1.0")]
    [HttpGet("areas")]
    [SwaggerOperation(Summary = "Metodo que lista las areas existentes")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(GetAreasResponseModelExample))]
    public async Task<IActionResult> GetAreas()
    {
        try
        {
            _logger.LogInformation("GetAreas");

            var result = await _mediator.Send(new GetAreasRequest());

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

    #region [GET] Get Ticket By Area
    [MapToApiVersion("1.0")]
    [HttpGet("ticketstype")]
    [SwaggerOperation(Summary = "Metodo que lista los tickets por area")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(GetTicketbyAreaResponseModelExample))]
    public async Task<IActionResult> GetTicketbyArea(string area)
    {
        try
        {
            _logger.LogInformation("GetTicketByArea");

            var result = await _mediator.Send(new GetTicketByAreaRequest() { Area = area });

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

    #region [GET] Get User Status
    [MapToApiVersion("1.0")]
    [HttpGet("user-status")]
    [SwaggerOperation(Summary = "Metodo que lista los tickets por area")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(ListUserStatusResponseModelExample))]
    public async Task<IActionResult> ListUserStatus()
    {
        try
        {
            _logger.LogInformation("List User Status");

            var result = await _mediator.Send(new ListUserStatusRequest() { });

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
