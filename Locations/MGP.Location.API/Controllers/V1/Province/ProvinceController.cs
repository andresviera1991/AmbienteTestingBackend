using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using MGP.Location.Application.UseCase.V1.Province.GetAll;
using Microsoft.AspNetCore.Http;
using MGP.Location.API.Controllers.V1.Province.Response;
using System;
using Asp.Versioning;

namespace MGP.Location.API.Controllers.V1.Province
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class ProvinceController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ProvinceController> _logger;
        private readonly IMapper _mapper;

        public ProvinceController(
            IMediator mediator,
            ILogger<ProvinceController> logger,
            IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [MapToApiVersion("1.0")]
        [HttpGet("Provinces")]
        [SwaggerOperation(
            Summary = "Obtener la lista de completa de provincias.",
            Description = "Este método devuelve la lista completa de todas las provincias disponibles en el sistema y que son parte de Argentina."
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetAllProvincesResponseModelExample))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ErrorModelExample))]
        public async Task<IActionResult> GetProvinces()
        {
            try
            {
                _logger.LogInformation($"Get Provinces");
                var result = await _mediator.Send(new GetAllProvincesRequest());

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, new { Error = "An unexpected error occurred." });
            }
        }
    }
}
