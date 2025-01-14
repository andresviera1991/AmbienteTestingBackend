using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;
using MGP.Authentication.Application.UseCase.V1.Authentication.Login;
using MGP.Authentication.Application.UseCase.V1.Authentication.Register;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.API.Controllers.V1.Auth.Request.Register;
using MGP.Authentication.Application.UseCase.V1.Authentication.ValidateUser;
using MGP.Authentication.API.Controllers.V1.Auth.Request.Login;
using MGP.Authentication.Application.UseCase.V1.Authentication.Logout;
using MGP.Authentication.Application.UseCase.V1.Authentication.RefreshSessionToken;
using MGP.Authentication.API.Controllers.V1.Auth.Request.NewToken;
using MGP.Authentication.API.Controllers.Swagger.Authentication.Validate;
using MGP.Authentication.API.Controllers.Swagger.Authentication.Login;
using MGP.Authentication.API.Controllers.Swagger.Authentication.Logout;
using MGP.Authentication.API.Controllers.Swagger.Authentication.NewToken;
using MGP.Authentication.API.Controllers.Swagger.Authentication.Register;
using Asp.Versioning;
using MGP.Authentication.API.Controllers.V1.Auth.Request.RegisterByAgent;
using MGP.Authentication.Application.UseCase.V1.Authentication.RegisterByAgent;
namespace MGP.Authentication.API.Controllers.V1.Auth;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<AuthController> _logger;
    private readonly IMapper _mapper;
    private const string InternalServerError = "Ha ocurrio un error inesperado";

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
    [SwaggerOperation(Summary = "Metodo de Creación de Usuario",Description = "<strong>Este endpoint permite registrar un nuevo usuario proporcionando los campos necesarios. Si el registro es exitoso, se envía un correo electrónico de validación al usuario para completar el proceso de registro junto un Token de validación. En caso de que el registro falle, se retorna un mensaje detallado del error. </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para la creación de usuario.</em>")]
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
                (int)Code.Created => Created("",result),
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.Conflict => Conflict(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
                _ => StatusCode(StatusCodes.Status503ServiceUnavailable, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = InternalServerError});
        }
    }
    #endregion

    #region [POST] Register By Agent
    [MapToApiVersion("1.0")]
    [HttpPost("register-by-agent")]
    [SwaggerOperation(Summary = "Metodo de Creación de Usuario", Description = "<strong>Este endpoint le permite al agente registrar un nuevo usuario proporcionando los campos necesario. El password será el número de documento. </strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para la creación de usuario.</em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(RegisterResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Bad request", typeof(RegisterResponseModel400))]
    public async Task<IActionResult> RegisterByAgent([FromBody] RegisterByAgentRequestModel request)
    {
        try
        {
            _logger.LogInformation("Register-by-agent");

            var result = await _mediator.Send(_mapper.Map<RegisterByAgentRequest>(request));

            return result.Code switch
            {
                (int)Code.Created => Created("", result),
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

    #region [GET] Validate User Register
    [MapToApiVersion("1.0")]
    [HttpGet("validate")]
    [SwaggerOperation(Summary = "Validar Creación de Usuario",Description = "<strong>Este método recibe un token de validación que ha sido proporcionado al usuario a través de un enlace enviado por correo electrónico. El token se utiliza para verificar la identidad del usuario y completar el proceso de registro. Si el token es válido, se confirma la cuenta del usuario y el registro se finaliza con éxito.</strong><br><br> <em>A continuación se detalla el ejemplo de una solicitud para la validación de usuario.</em>")]
    [SwaggerResponse(StatusCodes.Status201Created, "OK", typeof(ValidateRegisterResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(ValidateResponseModel400))]
    public async Task<IActionResult> ValidateUser([FromQuery] string token)
    {
        try
        {
            _logger.LogInformation("Validate");
            ValidateRegisterRequest validateUserRequest = new() { Token = token };
            var result = await _mediator.Send(validateUserRequest);

            return result.Code switch
            {
                (int)Code.Created => Created("",result),
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

    #region [POST] Login
    [MapToApiVersion("1.0")]
    [HttpPost("login")]
    [SwaggerOperation(Summary = "Metodo de Autenticación de Usuario",Description = "<strong>Este método permite a un usuario iniciar sesión proporcionando su DNI y la contraseña generada durante el registro. Si las credenciales son correctas y el usuario ha validado su cuenta, se retorna dos tokens (de acceso y de refresco) que permiten la autenticación en futuras solicitudes. Si el usuario no ha validado su cuenta, se enviará un nuevo correo electrónico de validación junto a un token que no tiene expiración. En caso de credenciales incorrectas o si ocurre algún otro error, se proporcionará un mensaje detallado explicando el motivo del fallo.</strong><br><br> <em>A continuación se detalla el ejemplo de Inicio de Sesión.</em>")]
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
            return StatusCode(500, new { Error = InternalServerError });
        }
    }
    #endregion

    #region [POST] New Token
    [MapToApiVersion("1.0")]
    [HttpPost("newtokens")]
    [SwaggerOperation(Summary = "Método de Generación de Tokens",Description = "<strong>Este método recibe un Refresh Token y, si es válido, proporciona nuevos tokens (de acceso y refresco) para continuar con las solicitudes. El Refresh Token proporcionado se almacena temporalmente para evitar su reutilización.</strong><br><br> <em>A continuación se detalla el ejemplo de generación de tokens.</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(LoginResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(NewTokenResponseModel400))]
    public async Task<IActionResult> CreateTokens(CreateTokensRequestModel createTokensRequestModel)
    {
        try
        {
            _logger.LogInformation($"Logout");
            var result = await _mediator.Send(new NewSessionTokenRequest() { RefreshToken = createTokensRequestModel.RefreshToken });
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
    [SwaggerOperation( Summary = "Metodo de Cierre de Sesión", Description = "<strong>Este método recibe un Refresh Token y lo almacena para evitar que se emitan nuevos tokens de acceso a partir de él. Una vez procesado el Refresh Token, el frontend debe eliminar cualquier información de tokens (de acceso y refresco) para asegurar que no se puedan realizar más solicitudes autenticadas. El token de acceso continuará siendo válido hasta que expire, pero no se podrán generar nuevos tokens de acceso con el Refresh Token proporcionado.</strong><br><br> <em>A continuación se detalla el ejemplo de cierre de sesión</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "Success", typeof(LogoutResponseModelExample))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(LogoutResponseModel401))]
    public async Task<IActionResult> Logout(LogoutRequestModel logoutRequestModel)
    {
        try
        {
            _logger.LogInformation($"Logout");

            var result = await _mediator.Send(new LogoutRequest() { RefreshToken = logoutRequestModel.RefreshToken });

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

