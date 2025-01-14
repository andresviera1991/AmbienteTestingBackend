using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.Discapacidad.API.Controllers.V1.Chat.Request;
using MGP.Discapacidad.CrossCutting.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using AutoMapper;
using MGP.Discapacidad.Application.UseCase.V1.Chat.GetMessages;
namespace MGP.Discapacidad.API.Controllers.V1.Chat;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/chat")]
public class ChatController : ControllerBase 
{
    private readonly IMediator _mediator;
    private readonly ILogger<ChatController> _logger;
    private readonly IMapper _mapper;

    public ChatController(IMediator mediator,
                          ILogger<ChatController> logger,
                          IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }


    #region Get Messages
    [MapToApiVersion("1.0")]
    [HttpGet("get-messages")]
    [SwaggerOperation(Summary = "Metodo de Obtención de Historial de Chat", Description = "<strong>Esta funcionalidad permite recibir el historial del chat</strong>")]
    public async Task<IActionResult> GetMessagesAsync([FromQuery] GetMessagesRequestModel request)
    {
        try
        {
            _logger.LogInformation($"GetMessages");


            var result = await _mediator.Send(_mapper.Map<GetMessagesRequest>(request));
           
            return result.Code switch
            {
                (int)Code.SUCCESS => Ok(result),
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


}
