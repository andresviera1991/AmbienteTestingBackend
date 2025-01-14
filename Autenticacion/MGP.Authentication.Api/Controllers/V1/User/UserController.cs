using Asp.Versioning;
using AutoMapper;
using MediatR;
using MGP.Authentication.API.Controllers.Swagger.Authentication.GetUser;
using MGP.Authentication.API.Controllers.Swagger.Authentication.Register;
using MGP.Authentication.Application.UseCase.V1.User.GetUser;
using MGP.Authentication.Application.UseCase.V1.User.Update;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.Authentication.API.Controllers.V1.User.Request;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.Application.UseCase.V1.User.Delete;
using MGP.Authentication.API.Controllers.Swagger.Authentication.DeleteUser;
using MGP.Authentication.Application.UseCase.V1.User.List.ListUserIds;
using MGP.Authentication.Application.UseCase.V1.User.List.ListUsers;
namespace MGP.Authentication.API.Controllers.V1.User;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/user")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<UserController> _logger;
    private readonly IMapper _mapper;
    private const string InternalServerError = "Ha ocurrido un error inesperado";
    public UserController(IMediator mediator,
                          ILogger<UserController> logger,
                          IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region [GET] GET USER (neighbor)
    [MapToApiVersion("1.0")]
    [HttpGet("get")]
    [SwaggerOperation(Summary = "Metodo para obtener los datos del Usuario",Description = "<strong>Este endpoint permite obtener los datos del Usuario </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para obtener los datos del usuario.</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetUserResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> GetUser([FromHeader] Guid userId)
    {
        try
        {
            _logger.LogInformation("Get User");
            var result = await _mediator.Send(new GetUserRequest() { UserId = userId });

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
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

    #region [GET] GET USER (employee)
    [MapToApiVersion("1.0")]
    [HttpGet("get-for-employee")]
    [SwaggerOperation(Summary = "Metodo para obtener los datos del Usuario por parte de un agente", Description = "<strong>Este endpoint permite obtener los datos del Usuario </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para obtener los datos del usuario.</em>"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetUserResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> GetUserForEmployee([FromQuery] Guid userId)
    {
        try
        {
            _logger.LogInformation("Get User");
            var result = await _mediator.Send(new GetUserRequest() { UserId = userId });

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
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

    #region [GET] LIST USER BY FILTERS (employee)
    [MapToApiVersion("1.0")]
    [HttpGet("list-by-filters")]
    [SwaggerOperation(Summary = "Metodo para listar usuarios por filtro", Description = "<strong>Este endpoint permite a un empleado municipal listar vecinos por filtro </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para obtener los datos del usuario.</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(GetUserResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> GetUserForEmployee([FromQuery] ListUserByFiltersRequestModel listUserByFiltersRequestModel)
    {
        try
        {
            _logger.LogInformation("Get User");
            var result = await _mediator.Send(_mapper.Map<ListUsersByFiltersRequest>(listUserByFiltersRequestModel));

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
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

    #region [GET] LIST USER IDS BY FILTERS (employee)
    [MapToApiVersion("1.0")]
    [HttpGet("list-ids-by-filters")]
    [SwaggerOperation(
        Summary = "Metodo para obtener los ids de los usuarios en base a un filtro",
        Description = "<strong>Este endpoint permite obtener los datos del Usuario basados en un filtro </strong>")]

    public async Task<IActionResult> ListUserIdsByFilters([FromQuery] ListUserIdsByFiltersRequestModel request)
    {
        try
        {
            _logger.LogInformation("List userIds");
            var result = await _mediator.Send(_mapper.Map<ListUserIdsByFiltersRequest>(request));

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.Conflict => Conflict(result),
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

    #region [PATCH] Update (neighbor)
    [MapToApiVersion("1.0")]
    [HttpPatch("update")]
    [SwaggerOperation(
        Summary = "Metodo de Modificación de Usuario",
        Description = "<strong>Este endpoint utiliza el método HTTP PATCH para actualizar los campos del perfil del usuario que fueron completados durante el registro. Permite modificar uno o varios campos de forma parcial. Solo se pueden actualizar los campos que están presentes en el modelo de usuario original. Las actualizaciones se aplican únicamente a los campos enviados en la solicitud, sin necesidad de incluir todos los datos del usuario. <em>Nota: Para hacer uso de este endpoint el usuario debe proporcionar el token de acceso en el encabezado de Authorization.</em></strong>" +
        "<br><br> <em>A continuación se detalla el ejemplo modificación de usuarios</em>"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(UpdateUserResponse))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> Update([FromBody] UpdateUserRequestModel requestModel, [FromHeader] Guid userId)
    {
        try
        {
            _logger.LogInformation("Update User");
            var request = _mapper.Map<UpdateUserRequest>(requestModel);
            request.UserId = userId;
            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
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

    #region [PATCH] Update (employee)
    [MapToApiVersion("1.0")]
    [HttpPatch("update-for-employee")]
    [SwaggerOperation(
        Summary = "Metodo de Modificación de Usuario para agentes",
        Description = "<strong>Este endpoint utiliza el método HTTP PATCH para actualizar los campos del perfil del usuario que fueron completados durante el registro. Permite modificar uno o varios campos de forma parcial. Solo se pueden actualizar los campos que están presentes en el modelo de usuario original. Las actualizaciones se aplican únicamente a los campos enviados en la solicitud, sin necesidad de incluir todos los datos del usuario. <em>Nota: Para hacer uso de este endpoint el usuario debe proporcionar el token de acceso en el encabezado de Authorization.</em></strong>" +
        "<br><br> <em>A continuación se detalla el ejemplo modificación de usuarios</em>"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(UpdateUserResponse))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> UpdateUserForEmployee([FromBody] UpdateUserForEmployeRequestModel request)
    {
        try
        {
            _logger.LogInformation("Update User");
            var result = await _mediator.Send(_mapper.Map<UpdateUserRequest>(request));

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),

                (int)Code.Conflict => Conflict(result),
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

    #region [DELETE] Delete
    [HttpDelete("delete")]
    [SwaggerOperation(
        Summary = "Metodo de Eliminación de Usuario",
        Description = "<strong>Este endpoint utiliza el método HTTP DELETE para eliminar un usuario.</em></strong>" +
        "<br><br> <em>A continuación se detalla el ejemplo de eliminación de usuarios</em>"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(DeleteUserResponseModalExample))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> Delete([FromHeader] Guid userId)
    {
        try
        {
            _logger.LogInformation("Delete User");
            DeleteUserRequest request = new DeleteUserRequest() { UserId = userId };
            var result = await _mediator.Send(request);

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Conflict => Conflict(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
                _ => StatusCode(StatusCodes.Status503ServiceUnavailable, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = InternalServerError });
        }
        #endregion

    }
}
