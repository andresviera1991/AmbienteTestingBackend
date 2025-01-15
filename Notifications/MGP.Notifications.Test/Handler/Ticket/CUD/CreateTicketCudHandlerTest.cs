//using AutoMapper;
//using FluentValidation;
//using MGP.Notifications.CrossCutting.Excepciones;
//using MGP.Notifications.CrossCutting.Helpers;
//using MGP.Notifications.CrossCutting.MessagesManager;
//using Moq;
//using Xunit;

//namespace MGP.Notifications.Test.Handler.Ticket.CUD
//{
//    public class CreateTicketCudHandlerTest
//    {
//        private readonly Mock<ITicketService> _ticketServiceMock;
//        private readonly Mock<IValidator<CreateTicketCudRequest>> _validatorMock;
//        private readonly Mock<IMapper> _mapperMock;
//        private readonly MessageManager _messageManager;
//        private readonly CreateTicketCudHandler _handler;

//        public CreateTicketCudHandlerTest()
//        {
//            _ticketServiceMock = new Mock<ITicketService>();
//            _validatorMock = new Mock<IValidator<CreateTicketCudRequest>>();
//            _mapperMock = new Mock<IMapper>();

//            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
//            if (!Directory.Exists(testPath)) { Directory.CreateDirectory(testPath); }
//            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

//            _handler = new CreateTicketCudHandler(_ticketServiceMock.Object, _validatorMock.Object, _mapperMock.Object, _messageManager);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
//        {
//            Guid userId = Guid.NewGuid();
//            Guid ticketId = Guid.NewGuid();

//            var request = new CreateTicketCudRequest
//            {
//                Email = "test@example.com",
//                TicketCode = "TICKET123",
//                TicketStatusId = 1,
//                Certificate = true,
//                ExpiredCertificate = false,
//                CertificateExpansionOptionsId = 1,
//                LostCertificate = false,
//                HealthInsurance = true,
//                PaySlip = true,
//                SignatureOptionId = 1,
//                DocumentComplete = true,
//                MedicalCommitteId = Guid.NewGuid(),
//                Documents = new List<CreateTicketCudDocumentRequest>()
//            };

//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
//                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

//            var ticketData = new CreateTicketCudData
//            {
//                UserId = userId,
//                Email = request.Email,
//                TicketCode = request.TicketCode,
//                TicketStatusId = request.TicketStatusId.Value,
//                Certificate = request.Certificate.Value,
//                ExpiredCertificate = request.ExpiredCertificate.Value,
//                CertificateExpansionOptionsId = request.CertificateExpansionOptionsId.Value,
//                LostCertificate = request.LostCertificate.Value,
//                HealthInsurance = request.HealthInsurance.Value,
//                PaySlip = request.PaySlip.Value,
//                SignatureOptionId = request.SignatureOptionId.Value,
//                DocumentComplete = request.DocumentComplete.Value,
//                MedicalCommitteId = request.MedicalCommitteId
//            };

//            var createdTicket = new CreateTicketCudResponse
//            {
//                Id = ticketId,
//                TicketCode = 1
//            };

//            _mapperMock.Setup(m => m.Map<CreateTicketCudData>(It.IsAny<CreateTicketCudRequest>()))
//                .Returns(ticketData);

//            _mapperMock.Setup(m => m.Map<CreateTicketCudResponse>(It.IsAny<CreateTicketCudData>()))
//                .Returns(createdTicket);

//            _ticketServiceMock.Setup(s => s.CreateTicketCudAsync(ticketData))
//                .ReturnsAsync(ticketData);

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.Created, result.Code);
//            Assert.Equal(createdTicket.Id, result.Data.Id);
//            Assert.Equal(createdTicket.TicketCode, result.Data.TicketCode);
//            Assert.Null(result.ErrorMessage);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnBadRequest_WhenParametersAreMissing()
//        {
//            Guid userId = Guid.NewGuid();
//            var request = new CreateTicketCudRequest
//            {
//                UserId = userId,
//                Email = "",
//                TicketCode = "TICKET123",
//                TicketStatusId = null,
//                Documents = new List<CreateTicketCudDocumentRequest>()
//            };

//            var validationResult = new FluentValidation.Results.ValidationResult
//            {
//                Errors = { new FluentValidation.Results.ValidationFailure("Email", "Email cannot be empty.") }
//            };
//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>())).ReturnsAsync(validationResult);

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.BadRequest, result.Code);
//        }

//        [Fact]
//        public async Task Handle_ShouldReturnConflict_WhenTicketAlreadyOpen()
//        {
//            Guid userId = Guid.NewGuid();
//            var request = new CreateTicketCudRequest
//            {
//                Email = "test@example.com",
//                TicketCode = "TICKET123",
//                TicketStatusId = 1,
//                Documents = new List<CreateTicketCudDocumentRequest>()
//            };

//            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
//                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

//            var ticketData = new CreateTicketCudData
//            {
//                UserId = userId,
//                Email = request.Email,
//                TicketCode = request.TicketCode,
//                TicketStatusId = request.TicketStatusId.Value,
//                Documents = new List<DocumentData>()
//            };

//            _mapperMock.Setup(m => m.Map<CreateTicketCudData>(request)).Returns(ticketData);
//            _ticketServiceMock.Setup(s => s.CreateTicketCudAsync(ticketData)).Throws(new TicketAlreadyOpenException());

//            var result = await _handler.Handle(request, CancellationToken.None);

//            Assert.Equal((int)Code.Conflict, result.Code);
//        }
//    }
//}