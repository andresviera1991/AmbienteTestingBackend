using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MGP.Location.API.Controllers.V1.Locality.Response;
using Asp.Versioning;
using MGP.Location.Application.UseCase.V1.Locality.GetLocality;
using MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId;

namespace MGP.Location.API.Controllers.V1.Locality
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class LocalityController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<LocalityController> _logger;
        private readonly IMapper _mapper;

        public LocalityController(
            IMediator mediator,
            ILogger<LocalityController> logger,
            IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("Localities/{departmentId}")]
        [SwaggerOperation(
            Summary = "Obtener la lista de localidades de un departamento.",
            Description = "Este método devuelve la lista de localidades disponibles para un departamento.\n\n" +
            "Es necesario proporcionar el ID del departamento obtenido previamente en el endpoint que devuelve la lista de departamentos"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetLocalitiesByDepartmentIdResponseModelExample))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ErrorModelExample))]
        public async Task<IActionResult> GetLocalities(
            [FromRoute, SwaggerParameter("ID de departamento. " +
            "Por ejemplo, ‘6357’.")] int departmentId)
        {
            try
            {
                _logger.LogInformation($"Get Localities");
                var result = await _mediator.Send(new GetLocalitiesByDepartmentIdRequest() 
                {
                    DepartmentId = departmentId
                });

                return Ok(result);
            }
            catch
            {
                return StatusCode(500, new { Error = "An unexpected error occurred." });
            }
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("Locality/{id}")]
        [SwaggerOperation(
            Summary = "Obtener la localidad, departamento y provincia por id de localidad.",
            Description = "Este método devuelve la localidad, departamento y provincia disponible por el id de localidad.\n\n" +
            "Es necesario proporcionar el ID de la localidad"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetLocalityModelExample))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ErrorModelExample))]
        public async Task<IActionResult> GetLocality(
            [FromRoute, SwaggerParameter("ID. " +
            "Por ejemplo, ‘6357110’.")] long id)
        {
            try
            {
                _logger.LogInformation($"Get Locality");
                var result = await _mediator.Send(new GetLocalityRequest()
                {
                    Id = id
                });

                return Ok(result);
            }
            catch
            {
                return StatusCode(500, new { Error = "An unexpected error occurred." });
            }
        }

    }
}
