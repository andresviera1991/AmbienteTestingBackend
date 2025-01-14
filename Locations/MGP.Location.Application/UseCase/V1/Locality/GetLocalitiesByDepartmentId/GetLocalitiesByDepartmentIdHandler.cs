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

namespace MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId
{
    public class GetLocalitiesByDepartmentIdHandler : IRequestHandler<GetLocalitiesByDepartmentIdRequest, ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>>
    {
        private readonly ILocalityService _localityService;
        private readonly IValidator<GetLocalitiesByDepartmentIdRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GetLocalitiesByDepartmentIdHandler(
            ILocalityService localityService,
            IValidator<GetLocalitiesByDepartmentIdRequest> validator,
            IMapper mapper,
            MessageManager messageManager)
        {
            _localityService = localityService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>> Handle(GetLocalitiesByDepartmentIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return new ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>
                        ((int)Code.BadRequest, null, new ResponseMessage()
                        {
                            Message = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                        });
                }

                IEnumerable<LocalityData> localities = await _localityService.GetLocalitiesByDepartmentId(request.DepartmentId);

                GetLocalitiesByDepartmentIdResponseList list = new GetLocalitiesByDepartmentIdResponseList()
                {
                    Localities = _mapper.Map<IEnumerable<GetLocalitiesByDepartmentIdResponse>>(localities)
                };
                return new ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>
                    ((int)Code.Success, list, null);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, FunctionalErrors.SERVICE_UNAVAILABLE);
            }
        }

        private async Task<ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>> HandleException(Code errorCode, string message, GetLocalitiesByDepartmentIdResponseList response = null)
        {
            var responseData = new ResponseData<GetLocalitiesByDepartmentIdResponseList, ResponseMessage>(
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
