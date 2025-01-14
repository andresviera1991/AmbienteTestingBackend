using AutoMapper;
using MediatR;
using MGP.Authentication.CrossCutting.Enum;
using MGP.Authentication.CrossCutting.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;
using System;
using MGP.Authentication.API.Controllers.V1.ResetPassword.Request;
using Microsoft.AspNetCore.Http;
using MGP.Authentication.Application.UseCase.V1.ResetPassword.ValidToken;
using MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword;
using MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.SendEmail;
using MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.ValidateToken;
using Asp.Versioning;
using MGP.Authentication.API.Controllers.V1.Password.Request;
using MGP.Authentication.Application.UseCase.V1.Password.Reset;
using MGP.Authentication.Application.UseCase.V1.Password.Change;
using MGP.Authentication.Application.UseCase.V1.Password.ResetSendEmail;
using MGP.Authentication.API.Controllers.Swagger.ResetPassword.ResetPassword.Change;
using MGP.Authentication.API.Controllers.Swagger.Messages;
namespace MGP.Authentication.API.Controllers.V1.ResetPassword;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/password")]
public class PasswordController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<PasswordController> _logger;
    private readonly IMapper _mapper;
    private const string InternalServerError = "Ha ocurrido un error inesperado";

    public PasswordController(IMediator mediator,
                              ILogger<PasswordController> logger,
                              IMapper mapper)
    {
        _mediator = mediator;
        _logger = logger;
        _mapper = mapper;
    }

    #region [POST] Change Password
    [MapToApiVersion("1.0")]
    [HttpPost("change")]
    [SwaggerOperation(Summary = "Método para modificar contraseña", Description = "<strong>Se reciben tres input. La contraseña anterior, la nueva y la nueva repetida, para verificación. <strong><br><br> <em>A continuación se detalla el ejemplo de resteo de contraseña</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ChangePasswordResponseModel))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Service Unavailable", typeof(ChangePasswordResponseModel400))]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequestModel request, [FromHeader] Guid userId)
    {
        try
        {
            ChangePasswordRequest changePasswordRequest = new ChangePasswordRequest()
            {
                UserId = userId,
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

    #region [POST] Send Email Reset Password
    [MapToApiVersion("1.0")]
    [HttpPost("send-email")]
    [SwaggerOperation(Summary = "Envío de Correo para Resetear Password",Description = "<strong>Recibe el nombre de usuario y envía un correo electrónico a la dirección asociada. El correo contiene un token de seguridad que deberá utilizarse para completar el proceso de restablecimiento de contraseña. El token no posee un tiempo de expiración, puede ser usado siempre para proporcionar una nueva contraseña, aunque por cuestiones de seguridad se recomienda que lo tenga. Se dará la misma respuesta, exista el usuario o no a fin de no proporcionar datos valiosos a los atacantes.</strong><br><br> <em>A continuación se detalla el ejemplo de resteo de contraseña</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(SendEmailResponseModel))]
    [SwaggerResponse(StatusCodes.Status503ServiceUnavailable, "Service Unavailable", typeof(SendEmailResponseModel503))]
    public async Task<IActionResult> SendEmail([FromQuery] string userName)
    {
        try
        {
            _logger.LogInformation($"sendemail");

            ResetPasswordEmailRequest emailRequest = new()
            {
                UserName = userName,
                EmailTypeEnum = EmailType.RESET_PASSWORD,
            };

            var result = await _mediator.Send(emailRequest);

            return result.Code switch
            {
                (int)Code.Success => Ok(result),
                (int)Code.BadRequest => BadRequest(result),
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
    [HttpPost("reset")]
    [SwaggerOperation(Summary = "Metodo de Reseteo de Password",Description = "<strong>Este endpoint recibe un token de seguridad, enviado previamente al correo electrónico del usuario para el reseteo de contraseña, junto con la nueva contraseña. Si la validación es exitosa, la contraseña del usuario se actualiza con la nueva proporcionada. En caso de que el token sea inválido o haya expirado, la solicitud es rechazada y no se realizan cambios en la cuenta del usuario.</strong><br><br> <em>A continuación se detalla el ejemplo de reseteo de password.</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ResetPasswordResponseModel))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(ValidateTokenResponseModel401))]
    public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordRequestModel request)
    {
        try
        {
            _logger.LogInformation($"resetPassword");

            var result = await _mediator.Send(_mapper.Map<ResetPasswordRequest>(request));

            return result.Code switch
            {
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Unauthorized => Unauthorized(result),
                (int)Code.Success => Ok(result),
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

    #region [GET] Validate Token
    [MapToApiVersion("1.0")]
    [HttpGet("verify-token")]
    [SwaggerOperation( Summary = "Metodo de Validación de Token", Description = "<strong>Este endpoint recibe un token de seguridad de reseteo de password y verifica si sigue siendo válido para su uso. El token es revisado para asegurarse de que no haya expirado. Si el token es válido, se confirma que puede ser utilizado en el proceso de cambio de contraseña. Este endpoint no realiza modificaciones, solo valida la vigencia del token. </strong><br><br> <em>A continuación se detalla el ejemplo de validación de Token.</em>")]
    [SwaggerResponse(StatusCodes.Status200OK, "OK", typeof(ValidateTokenResponseModel))]
    [SwaggerResponse(StatusCodes.Status401Unauthorized, "Unauthorized", typeof(ValidateTokenResponseModel401))]
    public async Task<IActionResult> ValidateToken([FromQuery] string token)
    {
        try
        {
            _logger.LogInformation($"validatetoken");
            ValidateTokenRequest validateTokenRequest = new() { Token = token };

            var result = await _mediator.Send(validateTokenRequest);

            return result.Code switch
            {
                (int)Code.BadRequest => BadRequest(result),
                (int)Code.NotFound => NotFound(result),
                (int)Code.Unauthorized => Unauthorized(result),
                (int)Code.Success => Ok(result),
                (int)Code.ServiceUnavailable => StatusCode(StatusCodes.Status503ServiceUnavailable, result),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result)
            };
        }
        catch (Exception)
        {
            return StatusCode(500, new { Error = InternalServerError });
        }

    }
    #endregion
}
