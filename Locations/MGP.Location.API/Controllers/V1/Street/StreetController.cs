using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MGP.Location.Application.UseCase.V1.Street.GetStreetsByName;
using MGP.Location.API.Controllers.V1.Street.Response;
using MGP.Location.API.Controllers.V1.Street.Request;
using Asp.Versioning;

namespace MGP.Location.API.Controllers.V1.Street
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class StreetController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<StreetController> _logger;
        private readonly IMapper _mapper;

        public StreetController(
            IMediator mediator,
            ILogger<StreetController> logger,
            IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [MapToApiVersion("1.0")]
        [ApiExplorerSettings(IgnoreApi = false)]
        [HttpGet("Streets")]
        [SwaggerOperation(
            Summary = "Obtener la lista de calles de una localidad por nombre.",
            Description = "Este método devuelve la lista de calles disponibles de una localidad.\n\n" +
            "Es necesario proporcionar el ID de la localidad obtenido previamente en el endpoint que devuelve la lista de localidades.\n\n" +
            "Se puede buscar la calle por el nombre completo o parcial"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetStreetsByNameResponseModelExample))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ErrorModelExample))]
        public async Task<IActionResult> GetStreetsByName([FromQuery] GetStreetsByNameRequestModel request)
        {
            try
            {
                _logger.LogInformation($"Get Streets By Name");
                var result = await _mediator.Send(_mapper.Map<GetStreetsByNameRequest>(request));

                return Ok(result);
            }
            catch
            {
                return StatusCode(500, new { Error = "An unexpected error occurred." });
            }
        }
    }
}
