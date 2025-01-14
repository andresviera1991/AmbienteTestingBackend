//using FluentValidation;
//using MGP.Audit.CrossCutting.Excepciones;
//using MGP.Audit.CrossCutting.Helpers;
//using MGP.Audit.CrossCutting.MessagesManager;
//using Moq;
//using Xunit;

//namespace MGP.Audit.Test.Handler.Ticket.GetById
//{
//    public class GetByIdHandlerTest
//    {
//        private readonly Mock<ITicketService> _ticketServiceMock;
//        private readonly Mock<IValidator<GetByIdRequest>> _validatorMock;
//        private readonly MessageManager _messageManager;
//        private readonly GetByIdHandler _handler;

//        public GetByIdHandlerTest()
//        {
//            _ticketServiceMock = new Mock<ITicketService>();
//            _validatorMock = new Mock<IValidator<GetByIdRequest>>();

//            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
//            if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
//            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

//            _handler = new GetByIdHandler(_ticketServiceMock.Object, _validatorMock.Object, _messageManager);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
//        {
//            var request = new GetByIdRequest
//            {
//                Id = Guid.NewGuid(),
//                UserId = Guid.NewGuid()
//            };

//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
//                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

//            var ticketData = new GetTicketCudData
//            {
//                Ticket = new TicketData { TicketCode = 123 }
//            };

//            _ticketServiceMock.Setup(s => s.GetTicketCudAsync(request.Id, request.UserId))
//                .ReturnsAsync(ticketData);

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.Success, result.Code);
//            Assert.Equal(ticketData.Ticket.TicketCode, result.Data.Ticket.TicketCode);
//            Assert.Null(result.ErrorMessage);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
//        {
//            var request = new GetByIdRequest
//            {
//                UserId = Guid.NewGuid()
//            };

//            var validationResult = new FluentValidation.Results.ValidationResult
//            {
//                Errors = { new FluentValidation.Results.ValidationFailure("Id", "Id cannot be empty.") }
//            };
//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.BadRequest, result.Code);
//            Assert.NotNull(result.ErrorMessage);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnNotFound_WhenTicketDoesNotExist()
//        {
//            var request = new GetByIdRequest
//            {
//                Id = Guid.NewGuid(),
//                UserId = Guid.NewGuid()
//            };

//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
//                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

//            _ticketServiceMock.Setup(s => s.GetTicketCudAsync(request.Id, request.UserId))
//                .Throws(new NotFoundException());

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.NotFound, result.Code);
//            Assert.NotNull(result.ErrorMessage);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnServiceUnavailable_WhenAnUnexpectedErrorOccurs()
//        {
//            var request = new GetByIdRequest
//            {
//                Id = Guid.NewGuid(),
//                UserId = Guid.NewGuid()
//            };

//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
//                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

//            _ticketServiceMock.Setup(s => s.GetTicketCudAsync(request.Id, request.UserId))
//                .Throws(new Exception("Some unexpected error"));

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.ServiceUnavailable, result.Code);
//            Assert.NotNull(result.ErrorMessage);
//        }
//    }
//}