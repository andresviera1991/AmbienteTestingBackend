using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;
using MGP.Backoffice.CrossCutting.Messages;
using Microsoft.EntityFrameworkCore;

namespace MGP.Backoffice.Application.UseCase.V1.UpdateAgent;

public class UpdateAgentHandler : IRequestHandler<UpdateAgentRequest, ResponseData<UpdateAgentResponse, ResponseMessage>>
{
    private readonly IUserService _userService;
    private readonly IValidator<UpdateAgentRequest> _validator;
    private readonly MessageManager _messageManager;
    private readonly IMapper _mapper;

    public UpdateAgentHandler(IUserService userService,
                              IValidator<UpdateAgentRequest> validator,
                              MessageManager messageManager,
                              IMapper mapper)
    {
        _userService = userService;
        _validator = validator;
        _messageManager = messageManager;
        _mapper = mapper;
    }

    public async Task<ResponseData<UpdateAgentResponse, ResponseMessage>> Handle(UpdateAgentRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            await _userService.UpdateAgentAync(_mapper.Map<UpdateAgentData>(request));

            var responseData = new ResponseData<UpdateAgentResponse, ResponseMessage>(
                           code: (int)Code.Success,
                           data: new UpdateAgentResponse() { Success = true },
                           message: null);

            return await Task.FromResult(responseData);
        }
        catch (ParameterNotProviderException e)
        {
            return await HandleException(Code.BadRequest, e.Errors);
        }
        catch (RegisterException e)
        {
            return await HandleException(Code.BadRequest, e.ErrorMessages);
        }
        catch (RoleNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.ROLE_NOT_FOUND)]);
        }
        catch (AreaNotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.AREA_NOT_FOUND)]);
        }
        catch (NotFoundException)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.USER_NOT_EXISTS)]);
        }
        catch (TicketTypeNotFoundException)
        {
            return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.TICKET_TYPE_NOT_FOUND)]);
        }
        catch (TicketTypeException)
        {
            return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.TICKET_TYPE_NOT_FOUND)]);
        }
        catch (AreaTicketTypeException)
        {
            return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.AREA_TICKET_TYPE_ERROR)]);
        }
        catch (DbUpdateException)
        {
            return await HandleException(Code.BadRequest, [_messageManager.GetNotification(FunctionalErrors.USER_ALREADY_EXISTS)]);
        }
        catch (Exception)
        {
            return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
        }
    }

    private static async Task<ResponseData<UpdateAgentResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
    {
        var responseData = new ResponseData<UpdateAgentResponse, ResponseMessage>(
                           code: (int)errorCode,
                           data: null,
                           message: new ResponseMessage()
                           {
                               Message = message
                           });

        return await Task.FromResult(responseData);
    }
}
