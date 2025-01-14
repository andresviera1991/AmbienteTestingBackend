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
using MGP.Location.Persistance.DTOs.Street;

namespace MGP.Location.Application.UseCase.V1.Street.GetStreetsByName
{
    public class GetStreetsByNameHandler : IRequestHandler<GetStreetsByNameRequest, ResponseData<GetStreetsByNameResponseList, ResponseMessage>>
    {
        private readonly IStreetService _streetService;
        private readonly IValidator<GetStreetsByNameRequest> _validator;
        private readonly IMapper _mapper;
        private readonly MessageManager _messageManager;

        public GetStreetsByNameHandler(
            IStreetService streetService,
            IValidator<GetStreetsByNameRequest> validator,
            IMapper mapper,
            MessageManager messageManager)
        {
            _streetService = streetService;
            _validator = validator;
            _mapper = mapper;
            _messageManager = messageManager;
        }

        public async Task<ResponseData<GetStreetsByNameResponseList, ResponseMessage>> Handle(GetStreetsByNameRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<StreetData> streets = await _streetService.GetStreetsByNameAsync(request.LocalityId, request.Name);

            GetStreetsByNameResponseList list = new GetStreetsByNameResponseList()
            {
                Streets = _mapper.Map<IEnumerable<GetStreetsByNameResponse>>(streets)
            };
            return new ResponseData<GetStreetsByNameResponseList, ResponseMessage>
                ((int)Code.Success, list, null);
        }
    }
}
