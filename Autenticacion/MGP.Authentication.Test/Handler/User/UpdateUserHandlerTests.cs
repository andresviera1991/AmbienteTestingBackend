using Moq;
using Xunit;
using FluentValidation;
using AutoMapper;
using MGP.Authentication.CrossCutting.MessagesManager;
using MGP.Authentication.Domain.Interfaces;
using MGP.Authentication.Persistance.DTOs;
using MGP.Authentication.CrossCutting.ResponseData;
using MGP.Authentication.CrossCutting.Helpers;
using Microsoft.EntityFrameworkCore;
using MGP.Authentication.CrossCutting.Exceptions;
using MGP.Authentication.Application.UseCase.V1.User.Update;
namespace MGP.Authentication.Test.Handler.User;

#pragma warning disable
public class UpdateUserHandlerTests
{
    private readonly Mock<IUserService> _userServiceMock;
    private readonly Mock<IValidator<UpdateUserRequest>> _validatorMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly MessageManager _messageManager;
    private readonly Mock<IJwtValidator> _jwtValidatorMock;
    private readonly UpdateUserHandler _handler;

    public UpdateUserHandlerTests()
    {
        _userServiceMock = new Mock<IUserService>();
        _validatorMock = new Mock<IValidator<UpdateUserRequest>>();
        _mapperMock = new Mock<IMapper>();

        string testPath = Path.Combine(Directory.GetCurrentDirectory(), "testPath");
        if (!Directory.Exists(testPath))
        {
            Directory.CreateDirectory(testPath);
        }
        _messageManager = new MessageManager(new ErrorMessagesProvider(testPath));

        _jwtValidatorMock = new Mock<IJwtValidator>();

        _handler = new UpdateUserHandler(
            _userServiceMock.Object,
            _validatorMock.Object,
            _mapperMock.Object,
            _messageManager
        );
    }

    [Fact]
    public async Task Handle_ShouldReturnSuccess_WhenValidationSucceeds()
    {
        // Arrange
        var request = new UpdateUserRequest { UserId = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var userData = new UserDataToUpdate { Id = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var updateUserResponse = new UpdateUserResponse();

        var responseData = new ResponseData<UpdateUserResponse, ResponseMessage>(
            code: (int)Code.Success,
            data: updateUserResponse,
            message: null
        );

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _mapperMock.Setup(m => m.Map<UserDataToUpdate>(request))
            .Returns(userData);

        _userServiceMock.Setup(s => s.PatchUserAsync(userData))
            .ReturnsAsync(userData);

        _mapperMock.Setup(m => m.Map<UpdateUserResponse>(userData))
            .Returns(updateUserResponse);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.Success, result.Code);
        Assert.Null(result.Message);
    }

    [Fact]
    public async Task Handle_ShouldReturnParameterNotProviderException()
    {
        // Arrange
        var request = new UpdateUserRequest { UserId = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var userData = new UserDataToUpdate { Id = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var updateUserResponse = new UpdateUserResponse();


        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _mapperMock.Setup(m => m.Map<UserDataToUpdate>(request))
            .Returns(userData);

        _userServiceMock.Setup(s => s.PatchUserAsync(userData))
            .ThrowsAsync(new ParameterNotProviderException());

        _mapperMock.Setup(m => m.Map<UpdateUserResponse>(userData))
            .Returns(updateUserResponse);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.BadRequest, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnError()
    {
        // Arrange
        var request = new UpdateUserRequest { UserId = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var userData = new UserDataToUpdate { Id = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var updateUserResponse = new UpdateUserResponse();
        var responseData = new ResponseData<UpdateUserResponse, ResponseMessage>(
            code: (int)Code.Success,
            data: updateUserResponse,
            message: null
        );

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _mapperMock.Setup(m => m.Map<UserDataToUpdate>(request))
            .Returns(userData);

        _userServiceMock.Setup(s => s.PatchUserAsync(userData))
            .ThrowsAsync(new DbUpdateException());

        _mapperMock.Setup(m => m.Map<UpdateUserResponse>(userData))
            .Returns(updateUserResponse);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.Conflict, result.Code);
    }

    [Fact]
    public async Task Handle_ShouldReturnDbUpdateException()
    {
        // Arrange
        var request = new UpdateUserRequest { UserId = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var userData = new UserDataToUpdate { Id = Guid.Parse("8f17ee94-8978-47c1-858b-46186d6bfb55") };
        var updateUserResponse = new UpdateUserResponse();
        var responseData = new ResponseData<UpdateUserResponse, ResponseMessage>(
            code: (int)Code.Success,
            data: updateUserResponse,
            message: null
        );

        _validatorMock.Setup(v => v.ValidateAsync(request, It.IsAny<CancellationToken>()))
            .ReturnsAsync(new FluentValidation.Results.ValidationResult());

        _mapperMock.Setup(m => m.Map<UserDataToUpdate>(request))
            .Returns(userData);

        _userServiceMock.Setup(s => s.PatchUserAsync(userData))
            .ThrowsAsync(new Exception());

        _mapperMock.Setup(m => m.Map<UpdateUserResponse>(userData))
            .Returns(updateUserResponse);

        // Act
        var result = await _handler.Handle(request, CancellationToken.None);

        // Assert
        Assert.Equal((int)Code.ServiceUnavailable, result.Code);
    }
}