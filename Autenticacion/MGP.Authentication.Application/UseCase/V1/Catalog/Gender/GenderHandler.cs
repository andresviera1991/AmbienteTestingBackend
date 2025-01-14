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

namespace MGP.Authentication.Application.UseCase.V1.Catalog.Gender
{
    public class GenderHandler : IRequestHandler<GenderRequest, ResponseData<List<GenderResponse>, ResponseMessage>>

    {
        private readonly ICatalogService _genderService;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GenderHandler(
            ICatalogService genderService,
            IMapper mapper,
            MessageManager messageManager)
        {
            _genderService = genderService;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<List<GenderResponse>, ResponseMessage>> Handle(GenderRequest request, CancellationToken cancellationToken)
        {
            try
            {
                List<GenderData> genderData = await _genderService.ListGenderAsync();
                List<GenderResponse> genderResponse = _mapper.Map<List<GenderResponse>>(genderData);

                var responseData = new ResponseData<List<GenderResponse>, ResponseMessage>(
                   code: (int)Code.Success,
                   data: genderResponse,
                   message: null);

                return await Task.FromResult(responseData);
            }
            catch (InvalidOperationException)
            {
                var responseData = new ResponseData<List<GenderResponse>, ResponseMessage>(
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
