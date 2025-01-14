using Asp.Versioning;
using AutoMapper;
using MediatR;
using MGP.Backoffice.Api.Controllers.Menu.Response;
using MGP.Backoffice.Application.UseCase.V1.Menu;
using MGP.Backoffice.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace MGP.Backoffice.Api.Controllers.Menu;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/menu")]
public class MenuController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<MenuController> _logger;
    private readonly IMapper _mapper;
    private const string InternalServerError = "An unexpected error occurred.";

    public MenuController(IMediator mediator,
                          ILogger<MenuController> logger,
                          IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region [GET] Get Menu Agent
    [MapToApiVersion("1.0")]
    [HttpGet("get")]
    [SwaggerOperation(Summary = "Metodo que lista los menus que puede ver un agente")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(GetMenuResponseModelExample))]
    public async Task<IActionResult> GetMenu([FromHeader] string role, [FromHeader] string area)
    {
        try
        {
            _logger.LogInformation("GetMenu");

            GetMenuRequest request = new()
            {
                Role = role,
                Area = area

            };
            var result = await _mediator.Send(_mapper.Map<GetMenuRequest>(request));

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
