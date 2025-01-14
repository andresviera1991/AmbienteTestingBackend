using AutoMapper;
using FluentValidation;
using MediatR;
using MGP.Backoffice.CrossCutting.Exceptions;
using MGP.Backoffice.CrossCutting.Helpers;
using MGP.Backoffice.CrossCutting.Messages;
using MGP.Backoffice.CrossCutting.MessagesManager;
using MGP.Backoffice.CrossCutting.ResponseData;
using MGP.Backoffice.Domain.DTOs;
using MGP.Backoffice.Domain.Interface;

namespace MGP.Backoffice.Application.UseCase.V1.Menu
{
    public class GetMenuHandler : IRequestHandler<GetMenuRequest, ResponseData<GetMenuResponse, ResponseMessage>>
    {
        private readonly IMenuService _menuService;
        private readonly IValidator<GetMenuRequest> _validator;
        private readonly MessageManager _messageManager;
        private readonly IMapper _mapper;

        public GetMenuHandler(IMenuService menuService,
                            IValidator<GetMenuRequest> validator,
                            MessageManager messageManager,
                            IMapper mapper)
        {
            _menuService = menuService;
            _validator = validator;
            _messageManager = messageManager;
            _mapper = mapper;
        }
        public async Task<ResponseData<GetMenuResponse, ResponseMessage>> Handle(GetMenuRequest request, CancellationToken cancellationToken)
        {

            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                    throw new ParameterNotProviderException(errorMessages);
                }

                List<MenuDto> menus = await _menuService.ListMenusAsync(_mapper.Map<AreaRolData>(request));

                var responseData = new ResponseData<GetMenuResponse, ResponseMessage>(
                               code: (int)Code.Success,
                               data: new GetMenuResponse() { Menus = menus },
                               message: null);

                return await Task.FromResult(responseData);

            }
            catch (ParameterNotProviderException e)
            {
                return await HandleException(Code.BadRequest, e.Errors);
            }
            catch (RoleNotFoundException)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.ROLE_NOT_FOUND)]);
            }
            catch (AreaNotFoundException)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.ROLE_NOT_FOUND)]);
            }
            catch (Exception)
            {
                return await HandleException(Code.NotFound, [_messageManager.GetNotification(FunctionalErrors.SERVICE_UNAVAILABLE)]);
            }
        }
        private static async Task<ResponseData<GetMenuResponse, ResponseMessage>> HandleException(Code errorCode, List<string> message)
        {
            var responseData = new ResponseData<GetMenuResponse, ResponseMessage>(
                               code: (int)errorCode,
                               data: null,
                               message: new ResponseMessage()
                               {
                                   Message = message
                               });

            return await Task.FromResult(responseData);
        }
    }
}
