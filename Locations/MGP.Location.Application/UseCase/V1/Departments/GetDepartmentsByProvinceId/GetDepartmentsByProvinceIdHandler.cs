using MGP.Location.CrossCutting.MessagesManager;
using MGP.Location.Domain.interfaces;
using AutoMapper;
using FluentValidation;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using MGP.Location.CrossCutting.ResponseData;
using MGP.Location.CrossCutting.Helpers;
using System.Collections.Generic;
using System.Linq;
using MGP.Location.Persistance.DTOs.Department;
using MGP.Location.CrossCutting.Messages;
using System;

namespace MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId
{
    public class GetDepartmentsByProvinceIdHandler : IRequestHandler<GetDepartmentsByProvinceIdRequest, ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>>
    {
        private readonly IDepartmentService _departmentService;
        private readonly IValidator<GetDepartmentsByProvinceIdRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GetDepartmentsByProvinceIdHandler(
            IDepartmentService departmentService,
            IValidator<GetDepartmentsByProvinceIdRequest> validator,
            IMapper mapper,
            MessageManager messageManager)
        {
            _departmentService = departmentService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>> Handle(GetDepartmentsByProvinceIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    return new ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>
                        ((int)Code.BadRequest, null, new ResponseMessage()
                        {
                            Message = validationResult.Errors.Select(e => e.ErrorMessage).ToList()
                        });
                }

                IEnumerable<DepartmentData> departments = await _departmentService.GetDepartmentsByProvinceId(request.ProvinceId);

                GetDepartmentsByProvinceIdResponseList list = new GetDepartmentsByProvinceIdResponseList()
                {
                    Departments = _mapper.Map<IEnumerable<GetDepartmentsByProvinceIdResponse>>(departments)
                };
                return new ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>
                    ((int)Code.Success, list, null);
            }
            catch (Exception)
            {
                return await HandleException(Code.ServiceUnavailable, FunctionalErrors.SERVICE_UNAVAILABLE);
            }
        }

        private async Task<ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>> HandleException(Code errorCode, string message, GetDepartmentsByProvinceIdResponseList response = null)
        {
            var responseData = new ResponseData<GetDepartmentsByProvinceIdResponseList, ResponseMessage>(
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
