using CQRSWebApplication.Common.CommandBus;
using CQRSWebApplication.Controllers;
using CQRSWebApplication.DTOs;
using NSubstitute;

namespace Test.CQRSWebApplication.Controllers;

public class CreateUserControllerTests
{
    [Fact]
    public void CreateUserIsNotImplemented()
    {
        var mockCommandBus = Substitute.For<CommandBus>();
        
        var createUSerController = new CreateUserController(mockCommandBus);
        var fooUSer = new User(1);
        Action executeMethod = () => createUSerController.Execute(fooUSer);

        var exception = Assert.Throws<NotImplementedException>(executeMethod);

        Assert.Equal("The method or operation is not implemented.", exception.Message);
        Assert.False(false);
    }
}

