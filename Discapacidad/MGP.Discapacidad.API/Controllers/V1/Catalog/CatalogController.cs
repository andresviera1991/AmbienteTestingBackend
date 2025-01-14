using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MediatR;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.Type;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.DocumentType;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.SignatureOptions;
using Asp.Versioning;
using MGP.Discapacidad.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.CertifiacteExpansionOptions;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.TicketStatus;
using MGP.Discapacidad.Application.UseCase.V1.Catalog.CardPickupLocationsOptions;

namespace MGP.Discapacidad.API.Controllers.V1.Catalog;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/catalog")]
public class CatalogController : ControllerBase
{
    private readonly IMediator _mediator;

    public CatalogController(IMediator mediator) { _mediator = mediator; }

    #region Ticket Type Options

    [HttpGet("ticket-types")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
        Summary = "Listar Tipos de Ticket",
       Description = "<strong>Este método devuelve la lista de tipos de tickets en el sistema <strong> "
    )]
    public async Task<IActionResult> GetTicketTypes()
    {
        try
        {
            var result = await _mediator.Send(new TicketTypeRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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

    #region Ticket Status Options

    [HttpGet("ticket-status")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
        Summary = "Listar los estados de los tickets",
       Description = "<strong>Este método devuelve la lista de estados posibles para un ticket<strong> ")]
    public async Task<IActionResult> GetTicketStatus()
    {
        try
        {
            var result = await _mediator.Send(new TicketStatusRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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

    #region Document Type Options

    [HttpGet("document-types")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
        Summary = "Listar Tipos de Documento",
       Description = "<strong>Este método devuelve la lista de tipos de documentos en el sistema <strong> "

    )]
    public async Task<IActionResult> GetDocumentTypes()
    {
        try
        {
            var result = await _mediator.Send(new DocumentTypeRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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

    #region Signature Options

    [HttpGet("signature-options")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
        Summary = "Listar opciones de firma",
       Description = "<strong>Este método devuelve la lista de metodos de firma en el sistema <strong> "
    )]
    public async Task<IActionResult> GetSignatureOptions()
    {
        try
        {
            var result = await _mediator.Send(new SignatureOptionsRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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

    #region Certificate Expansion Options

    [HttpGet("expansion-options")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
        Summary = "Listar motivos de expansión",
       Description = "<strong>Este método devuelve la lista de motivos por el cual un usuario puede extender el certificado <strong> "
    )]
    public async Task<IActionResult> CertificateExpansionOption()
    {
        try
        {
            var result = await _mediator.Send(new CertificateExpansionOptionsRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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

    #region Card Pickup Location

    [HttpGet("card-pickup-options")]
    [MapToApiVersion("1.0")]
    [SwaggerOperation(
        Summary = "Listar lugares para retirar la tarjeta SUBE",
       Description = "<strong>Este método devuelve la lista de lugares donde el usuario puede pasar a retirar la tarjeta sube <strong> "
    )]
    public async Task<IActionResult> CardPickupLocationsOptions()
    {
        try
        {
            var result = await _mediator.Send(new CardPickupLocationsOptionsRequest());

            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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
