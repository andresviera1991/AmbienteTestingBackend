using Asp.Versioning;
using MediatR;
using MGP.Authentication.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.Authentication.Application.UseCase.V1.Catalog.Gender;
namespace MGP.Authentication.API.Controllers.V1.Catalog;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/catalog")]
public class CatalogController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<CatalogController> _logger;

    public CatalogController(IMediator mediator, ILogger<CatalogController> logger)

    {
        _mediator = mediator;
        _logger = logger;
    }

    #region List Gender Options

    [HttpGet("genders")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
       Summary = "Listar Generos",
       Description = "<strong>Este método devuelve la lista de generos disponibles en el sistema <strong> "
   )]
    public async Task<IActionResult> GetGenders()
    {
        try
        {
            _logger.LogInformation($"List Genders");
            var result = await _mediator.Send(new GenderRequest());

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status500InternalServerError, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = "An unexpected error occurred." });
        }
    }

    #endregion

    #region List User Status

    [HttpGet("userstatus")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation( Summary = "Listar User Status", Description = "<strong>Este método devuelve la lista de generos disponibles en el sistema <strong> ")]
    public async Task<IActionResult> GetUserStatus()
    {
        try
        {
            _logger.LogInformation($"List User status");
            var result = await _mediator.Send(new GenderRequest());

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status500InternalServerError, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = "An unexpected error occurred." });
        }
    }

    #endregion

}
