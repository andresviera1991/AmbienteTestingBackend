using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId;
using MGP.Location.API.Controllers.V1.Department.Response;
using Asp.Versioning;

namespace MGP.Location.API.Controllers.V1.Department
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<DepartmentController> _logger;
        private readonly IMapper _mapper;

        public DepartmentController(
            IMediator mediator,
            ILogger<DepartmentController> logger,
            IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;
        }

        [MapToApiVersion("1.0")]
        [HttpGet]
        [Route("Departments/{provinceId}")]
        [SwaggerOperation(
            Summary = "Obtener la lista de departamentos de una provincia.",
            Description = "Este método devuelve la lista de departamentos disponibles para una provincia.\n\n" +
            "Es necesario proporcionar el ID de la provincia obtenido previamente en el endpoint que devuelve la lista de provincias."
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetDepartmentsByProvinceIdResponseModelExample))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(ErrorModelExample))]
        public async Task<IActionResult> GetDepartments(
            [FromRoute, SwaggerParameter("ID de provincia. " +
            "Por ejemplo, ‘6’.")] int provinceId)
        {
            try
            {
                _logger.LogInformation($"Get Departments");
                var result = await _mediator.Send(new GetDepartmentsByProvinceIdRequest() 
                { 
                    ProvinceId = provinceId
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
