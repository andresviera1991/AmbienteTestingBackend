using FluentValidation;
using MediatR;
using MGP.Discapacidad.CrossCutting.Excepciones;
using MGP.Discapacidad.Domain.interfaces;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace MGP.Discapacidad.Application.UseCase.V1.Chat.VerifyTicket;

public class TicketExistHandler : IRequestHandler<TicketExistRequest, bool>
{
    private readonly ITicketService _ticketService;
    private readonly IValidator<TicketExistRequest> _validator;

    public TicketExistHandler(ITicketService ticketService,
                              IValidator<TicketExistRequest> validator)
    {
        _ticketService = ticketService;
        _validator = validator;
    }
    public async Task<bool> Handle(TicketExistRequest request, CancellationToken cancellationToken)
    {
		try
		{
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var errorMessages = validationResult.Errors.Select(error => error.ErrorMessage).ToList();
                throw new ParameterNotProviderException(errorMessages);
            }

            return await _ticketService.TicketExitsAsync(request.TicketId);
        }
		catch (Exception)
		{
            return false;
		}
    }
}
