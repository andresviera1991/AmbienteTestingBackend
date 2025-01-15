using MGP.Discapacidad.Application.UseCase.V1.Document.AddDocument;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveDocument;
using MGP.Discapacidad.API.Controllers.SwaggerExample.Response;
using Microsoft.AspNetCore.Http;
using MGP.Discapacidad.API.Controllers.SwaggerExample.Response.Document;
using Asp.Versioning;
using MGP.Discapacidad.API.Controllers.V1.Documentation.Request;
using MGP.Discapacidad.CrossCutting.Helpers;
using MGP.Discapacidad.API.Controllers.V1.Document.Request;
using MGP.Discapacidad.Application.UseCase.V1.Document.AddTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.UpdateTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.RemoveTemplate;
using MGP.Discapacidad.Application.UseCase.V1.Document.ListTemplates;

namespace MGP.Discapacidad.API.Controllers.V1.Document;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/document")]
public class DocumentController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly ILogger<DocumentController> _logger;

    public DocumentController(IMediator mediator, ILogger<DocumentController> logger, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
        _logger = logger;
    }

    #region [POST] ADD DOCUMENT
    [MapToApiVersion("1.0")]
    [HttpPost("add")]
    [SwaggerOperation(
        Summary = "Metodo para Agregar Documentación",
        Description = "<strong>Este método agrega una entrada de documento a un ticket, vinculando el documento al ticket por su ID y asegurando que esté correctamente asociado dentro del sistema.</strong>" +
        "<br/> <em>A continuación se muestra un ejemplo </em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(AddDocumentToTicketResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> AddDocumentToTicket([FromBody] AddDocumentRequestModelList request, [FromHeader] Guid? userId)
    {
        try
        {
            _logger.LogInformation($"Add Document");

            var AddDocumentRequest = _mapper.Map<AddDocumentRequestList>(request);
            AddDocumentRequest.UserId = userId;
            var result = await _mediator.Send(AddDocumentRequest);

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
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

    #region [POST] ADD DOCUMENT FOR EMPLOYEE
    [MapToApiVersion("1.0")]
    [HttpPost("add-for-employee")]
    [SwaggerOperation(Summary = "Metodo para Agregar Documentación",Description = "<strong>Este método permite a un agente agregar un documento a un ticket, vinculando el documento al ticket por su ID y asegurando que esté correctamente asociado dentro del sistema.</strong><br/> <em>A continuación se muestra un ejemplo </em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(AddDocumentToTicketResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> AddDocumentToTicketForEmployee([FromBody] AddDocumentRequestModelList request)
    {
        try
        {
            _logger.LogInformation($"Add Document for employee");

            var AddDocumentRequest = _mapper.Map<AddDocumentRequestList>(request);
            var result = await _mediator.Send(AddDocumentRequest);

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
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

    #region [DELETE] DELETE DOCUMENT
    [MapToApiVersion("1.0")]
    [HttpDelete("delete")]
    [SwaggerOperation(
        Summary = "Metodo para eliminar un Documento",
        Description = "<strong>Este metodo elimina un Documento asociado al Ticket</strong>" +
        "<br/> <em>A continuación se muestra un ejemplo</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(RemoveDocumentFromTicketResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> RemoveDocumentFromTicket([FromQuery] string id, [FromHeader] Guid userId)
    {
        try
        {
            RemoveDocumentRequest removeDocumentRequest = new RemoveDocumentRequest()
            {
                Id = Guid.Parse(id),
                UserId = userId
            };

            var responseData = await _mediator.Send(removeDocumentRequest);

            return Ok(responseData);
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = "An unexpected error occurred." });
        }
    }
    #endregion

    #region Template Methods

    #region [POST] ADD TEMPLATE 
    [MapToApiVersion("1.0")]
    [HttpPost("add-template")]
    [SwaggerOperation(Summary = "Metodo para agregar un template asociado a un tipo de trámite", Description = "<strong>Este método permite a un supervisor agregar una plantilla a un tipo de ticket</strong><br/> <em>A continuación se muestra un ejemplo </em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> AddTemplate([FromBody] AddTemplateRequestModel addTemplateRequestModel)
    {
        try
        {
            _logger.LogInformation($"Add Template");


            var result = await _mediator.Send(_mapper.Map<AddTemplateRequest>(addTemplateRequestModel));

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
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

    #region [POST] UPDATE TEMPLATES
    [MapToApiVersion("1.0")]
    [HttpPost("update-template")]
    [SwaggerOperation(Summary = "Metodo para agregar un template asociado a un tipo de trámite", Description = "<strong>Este método permite a un supervisor agregar una plantilla a un tipo de ticket</strong><br/> <em>A continuación se muestra un ejemplo </em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> UpdateTemplate([FromBody] UpdateTemplateRequestModel updateTemplateRequestModel)
    {
        try
        {
            _logger.LogInformation($"Add Template");


            var result = await _mediator.Send(_mapper.Map<UpdateTemplateRequest>(updateTemplateRequestModel));

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
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

    #region [POST] LIST TEMPLATES
    [MapToApiVersion("1.0")]
    [HttpGet("get-templates")]
    [SwaggerOperation(Summary = "Metodo para listar las planillas existentes, pudiendo filtrar por ticket type", Description = "<strong>Este metodo permite a un agente listar los templates existentes</strong><br/> <em>A continuación se muestra un ejemplo </em>")]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ResponseModel400))]
    public async Task<IActionResult> GetTemplates([FromQuery] int? ticketTypeId)
    {
        try
        {
            _logger.LogInformation($"Add Template");
            var result = await _mediator.Send(new ListTemplatesRequest() { TicketTypeId = ticketTypeId });

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

    #region [POST] REMOVE TEMPLATES
    [MapToApiVersion("1.0")]
    [HttpDelete("remove-template")]
    [SwaggerOperation(Summary = "Metodo para listar para eliminar una planilla existente", Description = "<strong>Este metodo permite a un agente listar los templates existentes</strong><br/> <em>A continuación se muestra un ejemplo </em>")]
    public async Task<IActionResult> RemoveTemplate([FromQuery] Guid id)
    {
        try
        {
            _logger.LogInformation($"Add Template");
            var result = await _mediator.Send(new RemoveTemplateRequest() { Id = id });

            return result.Code switch
            {
                (int)Code.CREATED => Created("", result),
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

    #endregion

}
