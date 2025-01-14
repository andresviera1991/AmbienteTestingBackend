using AutoMapper;
using FluentValidation;
using MGP.Location.Application.UseCase.V1.Province.GetAll;
using MGP.Location.CrossCutting.MessagesManager;
using MGP.Location.Domain.interfaces;
using MGP.Location.Persistance.DTOs.Province;
using Moq;
using Xunit;
using MGP.Location.CrossCutting.Helpers;

namespace MGP.Location.Tests.Handler
{
    public class GetAllProvincesHandlerTests
    {
        private readonly Mock<IProvinceService> _provinceServiceMock;
        private readonly Mock<IValidator<GetAllProvincesRequest>> _validatorMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly MessageManager _messageManager;
        private readonly GetAllProvincesHandler _handler;

        public GetAllProvincesHandlerTests()
        {
            _provinceServiceMock = new Mock<IProvinceService>();
            _validatorMock = new Mock<IValidator<GetAllProvincesRequest>>();
            _mapperMock = new Mock<IMapper>();

            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
            if (!Directory.Exists(testPath))
            {
                Directory.CreateDirectory(testPath);
            }
            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

            _handler = new GetAllProvincesHandler(
                _provinceServiceMock.Object,
                _validatorMock.Object,
                _mapperMock.Object,
                _messageManager
            );
        }

        [Fact]
        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
        {
            // Arrange
            var request = new GetAllProvincesRequest();
            var provinceData = new ProvinceData
            {
                Id = 6,
                Name = "Buenos Aires"
            };
            var getAllProvincesResponseList = new GetAllProvincesResponseList()
            {
                Provinces = new List<GetAllProvincesResponse>()
                {
                    new GetAllProvincesResponse()
                    {
                        Id = 6,
                        Name = "Buenos Aires"
                    }
                }
            };

            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

            _mapperMock.Setup(m => m.Map<IEnumerable<GetAllProvincesResponse>>(It.IsAny<IEnumerable<ProvinceData>>()))
                .Returns(new List<GetAllProvincesResponse>
                {
                    new GetAllProvincesResponse { Id = 6, Name = "Buenos Aires" }
                });

            _provinceServiceMock.Setup(s => s.GetAll())
                .ReturnsAsync(new List<ProvinceData> { provinceData });

            // Act
            var result = await _handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal((int)Code.Success, result.Code);
            Assert.NotNull(result.Data);
            Assert.Equal(getAllProvincesResponseList.Provinces.First().Id, result.Data.Provinces.First().Id);
            Assert.Equal(getAllProvincesResponseList.Provinces.First().Name, result.Data.Provinces.First().Name);
            Assert.Null(result.Message);
        }

        [Fact]
        public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceThrowsException()
        {
            // Arrange
            var request = new GetAllProvincesRequest();
            var validationResult = new FluentValidation.Results.ValidationResult();

            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(validationResult);

            _provinceServiceMock.Setup(s => s.GetAll())
                .ThrowsAsync(new Exception("Service Unavailable"));

            // Act
            var result = await _handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);
            Assert.Null(result.Data);
        }
    }
}