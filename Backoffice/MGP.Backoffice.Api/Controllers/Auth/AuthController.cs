using Asp.Versioning;
using AutoMapper;
using MediatR;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.Api.Controllers.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;
using MGP.Backoffice.API.Controllers.V1.Auth.Request.NewToken;
using MGP.Backoffice.Api.Controllers.Auth.Request;
using MGP.Authentication.API.Controllers.V1.Auth.Request.Login;
using MGP.Authentication.API.Controllers.V1.Password.Request;
using ResetPasswordRequest = MGP.Backoffice.Application.UseCase.V1.Auth.ResetPassword.ResetPasswordRequest;
using RegisterRequest = MGP.Backoffice.Application.UseCase.V1.Auth.Register.RegisterRequest;
using LoginRequest = MGP.Backoffice.Application.UseCase.V1.Auth.Login.LoginRequest;
using MGP.Backoffice.Application.UseCase.V1.Auth.ChangePassword;
using MGP.Backoffice.Application.UseCase.V1.Auth.NewTokens;
using MGP.Backoffice.Application.UseCase.V1.Auth.Logout;
using MGP.Backoffice.Api.Controllers.Auth.Response;
using MGP.Backoffice.Api.Controllers.Swagger;

namespace MGP.Backoffice.Api.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/auth")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<AuthController> _logger;
    private readonly IMapper _mapper;
    private const string InternalServerError = "An unexpected error occurred.";

    public AuthController(IMediator mediator,
                          ILogger<AuthController> logger,
                          IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }


    #region [POST] Register
    [MapToApiVersion("1.0")]
    [HttpPost("register")]
    [SwaggerOperation(Summary = "Metodo de Creación de Usuario", Description = "<strong>Este endpoint permite registrar un nuevo usuario proporcionando los campos necesarios. Si el registro es exitoso, se envía un correo electrónico de validación al usuario para completar el proceso de registro junto un Token de validación. En caso de que el registro falle, se retorna un mensaje detallado del error. </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para la creación de usuario.</em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(RegisterResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> Register([FromBody] RegisterRequestModel request)
    {
        try
        {
            _logger.LogInformation("Register");

            var result = await _mediator.Send(_mapper.Map<RegisterRequest>(request));

            return result.Code switch
            {
                (int)Code.Created => Created("", result),
                (int)Code.NotFound => NotFound(result),
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

    #region [POST] Login
    [MapToApiVersion("1.0")]
    [HttpPost("login")]
    [SwaggerOperation(Summary = "Metodo de Autenticación de Usuario", Description = "<strong>Este método permite a un usuario iniciar sesión proporcionando su DNI y la contraseña generada durante el registro. Si las credenciales son correctas y el usuario ha validado su cuenta, se retorna dos tokens (de acceso y de refresco) que permiten la autenticación en futuras solicitudes. Si el usuario no ha validado su cuenta, se enviará un nuevo correo electrónico de validación junto a un token que no tiene expiración. En caso de credenciales incorrectas o si ocurre algún otro error, se proporcionará un mensaje detallado explicando el motivo del fallo.</strong><br><br> <em>A continuación se detalla el ejemplo de Inicio de Sesión.</em>"
    )]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(LoginResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Not Found", typeof(LoginResponseModel400))]
    public async Task<IActionResult> Login([FromBody] LoginRequestModel request)
    {
        try
        {
            _logger.LogInformation($"login");
            var result = await _mediator.Send(_mapper.Map<LoginRequest>(request));

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.Unauthorized => Unauthorized(result),
                (int)Code.Locked => StatusCode(StatusCodes.Status423Locked, result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
                _ => StatusCode(StatusCodes.Status503ServiceUnavailable, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new
            {
                Error = InternalServerError
            });
        }
    }
    #endregion

    #region [POST] New Token
    [MapToApiVersion("1.0")]
    [HttpPost("new-tokens")]
    [SwaggerOperation(Summary = "Método de Generación de Tokens", Description = "<strong>Este método recibe un Refresh Token y, si es válido, proporciona nuevos tokens (de acceso y refresco) para continuar con las solicitudes. El Refresh Token proporcionado se almacena temporalmente para evitar su reutilización.</strong><br><br> <em>A continuación se detalla el ejemplo de generación de tokens.</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(LoginResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(NewTokenResponseModel400))]
    public async Task<IActionResult> CreateTokens(NewTokensRequestModel createTokensRequestModel)
    {
        try
        {
            _logger.LogInformation($"Logout");

            var result = await _mediator.Send(new NewTokensRequest() { RefreshToken = createTokensRequestModel.RefreshToken });

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Unauthorized => Unauthorized(result),
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

    #region [POST] Logout
    [MapToApiVersion("1.0")]
    [HttpPost("logout")]
    [SwaggerOperation(Summary = "Metodo de Cierre de Sesión", Description = "<strong>Este método recibe un Refresh Token y lo almacena para evitar que se emitan nuevos tokens de acceso a partir de él. Una vez procesado el Refresh Token, el frontend debe eliminar cualquier información de tokens (de acceso y refresco) para asegurar que no se puedan realizar más solicitudes autenticadas. El token de acceso continuará siendo válido hasta que expire, pero no se podrán generar nuevos tokens de acceso con el Refresh Token proporcionado.</strong><br><br> <em>A continuación se detalla el ejemplo de cierre de sesión</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(LogoutResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(LogoutResponseModel401))]
    public async Task<IActionResult> Logout(LogoutRequestModel logoutRequestModel)
    {
        try
        {
            _logger.LogInformation($"Logout");
            var result = await _mediator.Send(new LogoutRequest() { RefreshToken = logoutRequestModel.RefreshToken });

            if (result.Code != (int)Code.Success) { return BadRequest(result); }
            return Ok(result);
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = InternalServerError });
        }
    }
    #endregion

    #region [POST] Change Password
    [MapToApiVersion("1.0")]
    [HttpPost("change-password")]
    [SwaggerOperation(Summary = "Método para modificar contraseña", Description = "<strong>Se reciben tres input. La contraseña anterior, la nueva y la nueva repetida, para verificación. <strong><br><br> <em>A continuación se detalla el ejemplo de resteo de contraseña</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ResetPasswordResponseModel))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(ValidateTokenResponseModel401))]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequestModel request, [FromHeader] Guid employeeId)
    {
        try
        {
            ChangePasswordRequest changePasswordRequest = new ChangePasswordRequest()
            {
                AgentId = employeeId,
                CurrentPassword = request.CurrentPassword,
                NewPassword = request.NewPassword,
            };

            var result = await _mediator.Send(changePasswordRequest);

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Unauthorized => Unauthorized(result),
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

    #region [POST] Reset Password
    [MapToApiVersion("1.0")]
    [HttpPost("reset-password")]
    [SwaggerOperation(Summary = "Método para solicitar que se modifique contraseña", Description = "<strong>Se solicita modificar la clave a un supervisor. En el caso de que la haya olvidado. <strong><br><br> <em>A continuación se detalla el ejemplo de resteo de contraseña</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ResetPasswordResponseModel))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(ValidateTokenResponseModel401))]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestModel request)
    {
        try
        {
            ResetPasswordRequest resetPasswordRequest = new ResetPasswordRequest()
            {
                EmployeeNumber = request.EmployeeNumber
            };

            var result = await _mediator.Send(resetPasswordRequest);

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Unauthorized => Unauthorized(result),
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

