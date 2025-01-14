using AutoMapper;
using FluentValidation;
using MGP.Location.CrossCutting.MessagesManager;
using MGP.Location.Domain.interfaces;
using Moq;
using Xunit;
using MGP.Location.CrossCutting.Helpers;
using MGP.Location.Application.UseCase.V1.Departments.GetDepartmentsByProvinceId;
using MGP.Location.Persistance.DTOs.Department;

namespace MGP.Location.Tests.Handler
{
    public class GetDepartmentsByProvinceIdHandlerTests
    {
        private readonly Mock<IDepartmentService> _departmentServiceMock;
        private readonly Mock<IValidator<GetDepartmentsByProvinceIdRequest>> _validatorMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly MessageManager _messageManager;
        private readonly GetDepartmentsByProvinceIdHandler _handler;

        public GetDepartmentsByProvinceIdHandlerTests()
        {
            _departmentServiceMock = new Mock<IDepartmentService>();
            _validatorMock = new Mock<IValidator<GetDepartmentsByProvinceIdRequest>>();
            _mapperMock = new Mock<IMapper>();

            string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
            if (!Directory.Exists(testPath))
            {
                Directory.CreateDirectory(testPath);
            }
            _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

            _handler = new GetDepartmentsByProvinceIdHandler(
                _departmentServiceMock.Object,
                _validatorMock.Object,
                _mapperMock.Object,
                _messageManager
            );
        }

        [Fact]
        public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
        {
            var request = new GetDepartmentsByProvinceIdRequest();
            var departmentData = new DepartmentData
            {
                Id = 6,
                Name = "General Pueyrredón"
            };
            var expectedResponseList = new GetDepartmentsByProvinceIdResponseList()
            {
                Departments = new List<GetDepartmentsByProvinceIdResponse>()
        {
            new GetDepartmentsByProvinceIdResponse()
            {
                Id = 6,
                Name = "General Pueyrredón"
            }
        }
            };

            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new FluentValidation.Results.ValidationResult());

            _mapperMock.Setup(m => m.Map<IEnumerable<GetDepartmentsByProvinceIdResponse>>(It.IsAny<IEnumerable<DepartmentData>>()))
                .Returns(new List<GetDepartmentsByProvinceIdResponse>
                {
            new GetDepartmentsByProvinceIdResponse { Id = 6, Name = "General Pueyrredón" }
                });

            _departmentServiceMock.Setup(s => s.GetDepartmentsByProvinceId(It.IsAny<int>()))
                .ReturnsAsync(new List<DepartmentData> { departmentData });

            var result = await _handler.Handle(request, CancellationToken.None);

            Assert.Equal((int)Code.Success, result.Code);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data.Departments);
            Assert.Equal(expectedResponseList.Departments.First().Id, result.Data.Departments.First().Id);
            Assert.Equal(expectedResponseList.Departments.First().Name, result.Data.Departments.First().Name);
            Assert.Null(result.Message);
        }

        [Fact]
        public async Task Handle_ShouldReturnServiceUnavailable_WhenServiceThrowsException()
        {
            // Arrange
            var request = new GetDepartmentsByProvinceIdRequest();
            var validationResult = new FluentValidation.Results.ValidationResult();

            _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
                .ReturnsAsync(validationResult);

            _departmentServiceMock.Setup(s => s.GetDepartmentsByProvinceId(It.IsAny<int>()))
                .ThrowsAsync(new Exception("Service Unavailable"));

            // Act
            var result = await _handler.Handle(request, CancellationToken.None);

            // Assert
            Assert.Equal((int)Code.ServiceUnavailable, result.Code);
            Assert.Null(result.Data);
        }
    }
}