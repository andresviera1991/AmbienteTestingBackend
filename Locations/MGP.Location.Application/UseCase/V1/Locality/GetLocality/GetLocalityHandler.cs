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
using System.Linq;
using MGP.Location.CrossCutting.Messages;
using System;

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocality
{
    public class GetLocalityHandler : IRequestHandler<GetLocalityRequest, ResponseData<GetLocalityResponse, ResponseMessage>>
    {
        private readonly ILocalityService _localityService;
        private readonly IValidator<GetLocalityRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GetLocalityHandler(
            ILocalityService localityService,
            IValidator<GetLocalityRequest> validator,
            IMapper mapper,
            MessageManager messageManager)
        {
            _localityService = localityService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<GetLocalityResponse, ResponseMessage>> Handle(GetLocalityRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return new ResponseData<GetLocalityResponse, ResponseMessage>
                        ((int)Code.BadRequest, null, new ResponseMessage()
                        {
                            Message = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                        });
                }

                LocalityDetailDto localy = await _localityService.GetLocalityDetailById(request.Id);

                return new ResponseData<GetLocalityResponse, ResponseMessage>
                    ((int)Code.Success, _mapper.Map<GetLocalityResponse>(localy) , null);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, FunctionalErrors.SERVICE_UNAVAILABLE);
            }
        }

        private async Task<ResponseData<GetLocalityResponse, ResponseMessage>> HandleException(Code errorCode, string message, GetLocalityResponse response = null)
        {
            var responseData = new ResponseData<GetLocalityResponse, ResponseMessage>(
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
