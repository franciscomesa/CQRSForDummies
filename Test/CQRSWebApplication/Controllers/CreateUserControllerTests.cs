using CQRSWebApplication.Commands;
using CQRSWebApplication.Common.CommandBus;
using CQRSWebApplication.Controllers;
using CQRSWebApplication.DTOs;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NSubstitute;

namespace Test.CQRSWebApplication.Controllers;

public class CreateUserControllerTests
{
    [Fact]
    public void FalseIsFalse()
    {
        Assert.False(false);        
    }
    
    [Fact]
    public void CreateUserIsNotImplemented()
    {
        var fooUSer = new User(1);
        var mockCommandBus = Substitute.For<CommandBus>();
        var createUSerController = new CreateUserController(mockCommandBus);
        Action executeMethod = () => createUSerController.Execute(fooUSer);

        var exception = Assert.Throws<NotImplementedException>(executeMethod);

        Assert.Equal("The method or operation is not implemented.", exception.Message);
    }

    [Fact]
    public void CreateUserSendCommandBus()
    {
        var fooUSer = new User(1);
        var mockCommandBus = Substitute.For<CommandBus>();
        var createUSerController = new CreateUserController(mockCommandBus);
        Action executeMethod = () => createUSerController.Execute(fooUSer);

        var exception = Assert.Throws<NotImplementedException>(executeMethod);
        
        mockCommandBus.Received().Send(Arg.Any<CreateUserCommand>()); // << This will fail if 2 or 4 calls were received

        Assert.Equal("The method or operation is not implemented.", exception.Message);
    }
}

