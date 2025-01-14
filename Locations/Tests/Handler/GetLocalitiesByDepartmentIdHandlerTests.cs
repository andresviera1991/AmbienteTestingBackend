using AutoMapper;
using FluentValidation;
using MGP.Location.CrossCutting.MessagesManager;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Province;
using Moq;
using Xunit;
using MGP.Location.CrossCutting.Helpers;
using MGP.Location.Application.UseCase.V1.Locality.GetLocalitiesByDepartmentId;

namespace MGP.Location.Tests.Handler
{
    public class GetLocalitiesByDepartmentIdHandlerTests
    {
        private readonly Mock<ILocalityService> _localityServiceMock;
        private readonly Mock<IValidator<GetLocalitiesByDepartmentIdRequest>> _validatorMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly MessageManager _messageManager;
        private readonly GetLocalitiesByDepartmentIdHandler _handler;

        public GetLocalitiesByDepartmentIdHandlerTests()
        {
            _localityServiceMock = new Mock<ILocalityService>();
            _validatorMock = new Mock<IValidator<GetLocalitiesByDepartmentIdRequest>>();
            _mapperMock = new Mock<IMapper>();

            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
            if (!Directory.Exists(testPath))
            {
                Directory.CreateDirectory(testPath);
            }
            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

            _handler = new GetLocalitiesByDepartmentIdHandler(
                _localityServiceMock.Object,
                _validatorMock.Object,
                _mapperMock.Object,
                _messageManager
            );
        }

        [Fact]
        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
        {
            // Arrange
            var request = new GetLocalitiesByDepartmentIdRequest();
            var localityData = new LocalityData
            {
                Id = 6,
                Name = "Mar del Plata"
            };
            var getAllProvincesResponseList = new GetLocalitiesByDepartmentIdResponseList()
            {
                Localities = new List<GetLocalitiesByDepartmentIdResponse>()
                {
                    new GetLocalitiesByDepartmentIdResponse()
                    {
                        Id = 6,
                        Name = "Mar del Plata"
                    }
                }
            };

            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

            _mapperMock.Setup(m => m.Map<IEnumerable<GetLocalitiesByDepartmentIdResponse>>(It.IsAny<IEnumerable<LocalityData>>()))
                .Returns(new List<GetLocalitiesByDepartmentIdResponse>
                {
                    new GetLocalitiesByDepartmentIdResponse { Id = 6, Name = "Mar del Plata" }
                });

            _localityServiceMock.Setup(s => s.GetLocalitiesByDepartmentId(It.IsAny<int>()))
                .ReturnsAsync(new List<LocalityData> { localityData });

            // Act
            var result = await _handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal((int)Code.Success, result.Code);
            Assert.NotNull(result.Data);
            Assert.Equal(getAllProvincesResponseList.Localities.First().Id, result.Data.Localities.First().Id);
            Assert.Equal(getAllProvincesResponseList.Localities.First().Name, result.Data.Localities.First().Name);
            Assert.Null(result.Message);
        }

        [Fact]
        public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceThrowsException()
        {
            // Arrange
            var request = new GetLocalitiesByDepartmentIdRequest();
            var validationResult = new FluentValidation.Results.ValidationResult();

            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(validationResult);

            _localityServiceMock.Setup(s => s.GetLocalitiesByDepartmentId(It.IsAny<int>()))
                .ThrowsAsync(new Exception("Service Unavailable"));

            // Act
            var result = await _handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);
            Assert.Null(result.Data);
        }
    }
}