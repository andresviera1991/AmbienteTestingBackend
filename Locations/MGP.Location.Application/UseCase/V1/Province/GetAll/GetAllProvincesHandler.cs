using MGP.Location.CrossCutting.MessagesManager;
using MGP.Location.Domain.interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MGP.Location.CrossCutting.ResponseData;
using MGP.Location.CrossCutting.Helpers;
using MGP.Location.Persistance.DTOs.Province;
using System.Collections.Generic;
using MGP.Location.CrossCutting.Messages;
using System;

namespace MGP.Location.Application.UseCase.V1.Province.GetAll
{
    public class GetAllProvincesHandler : IRequestHandler<GetAllProvincesRequest, ResponseData<GetAllProvincesResponseList, ResponseMessage>>
    {
        private readonly IProvinceService _provinceService;
        private readonly IValidator<GetAllProvincesRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GetAllProvincesHandler(
            IProvinceService provinceService,
            IValidator<GetAllProvincesRequest> validator,
            IMapper mapper,
            MessageManager messageManager)
        {
            _provinceService = provinceService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<GetAllProvincesResponseList, ResponseMessage>> Handle(GetAllProvincesRequest request, CancellationToken cancellationToken)
        {
            try
            {
                IEnumerable<ProvinceData> provinces = await _provinceService.GetAll();

                GetAllProvincesResponseList list = new GetAllProvincesResponseList()
                {
                    Provinces = _mapper.Map<IEnumerable<GetAllProvincesResponse>>(provinces)
                };
                return new ResponseData<GetAllProvincesResponseList, ResponseMessage>
                    ((int)Code.Success, list, null);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, FunctionalErrors.SERVICE_UNAVAILABLE);
            }
        }

        private async Task<ResponseData<GetAllProvincesResponseList, ResponseMessage>> HandleException(Code errorCode, string message, GetAllProvincesResponseList response = null)
        {
            var responseData = new ResponseData<GetAllProvincesResponseList, ResponseMessage>(
                               code: (int)errorCode,
                               data: response,
                               message: new ResponseMessage()
                               {
                                   Message = new List<string>
                               {
                                    _messageManager.GetNotification(message)
                               }
                               });

            return await Task.FromResult(responseData);
        }
    }
}
