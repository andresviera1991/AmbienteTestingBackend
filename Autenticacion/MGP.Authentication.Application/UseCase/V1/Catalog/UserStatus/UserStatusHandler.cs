using AutoMapper;
using MediatR;
using MGP.Authentication.CrossCutting.Helpers;
using MGP.Authentication.CrossCutting.Messages;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MGP.Authentication.Application.UseCase.V1.Catalog.UserStatus
{
    public class UserStatusHandler : IRequestHandler<UserStatusRequest, ResponseData<List<UserStatusResponse>, ResponseMessage>>

    {
        private readonly ICatalogService _catalogService;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public UserStatusHandler(ICatalogService catalogService,
                                 IMapper mapper,
                                 MessageManager messageManager)
        {
            _catalogService = catalogService;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<List<UserStatusResponse>, ResponseMessage>> Handle(UserStatusRequest request, CancellationToken cancellationToken)
        {
            try
            {
                List<UserStatusData> genderData = await _catalogService.ListUserStatusAsync();
                List<UserStatusResponse> genderResponse = _mapper.Map<List<UserStatusResponse>>(genderData);

                var responseData = new ResponseData<List<UserStatusResponse>, ResponseMessage>(
                   code: (int)Code.Success,
                   data: genderResponse,
                   message: null);

                return await Task.FromResult(responseData);
            }
            catch (InvalidOperationException)
            {
                var responseData = new ResponseData<List<UserStatusResponse>, ResponseMessage>(
                   code: (int)Code.ServiceUnavailable,
                   data: null,
                   message: new ResponseMessage()
                   {
                       Message = [_messageManager.GetNotification(FunctionalMessages.SERVICE_UNAVAILABLE)]
                   });
                return await Task.FromResult(responseData);
            }
        }
    }
}
