using CQRSWebApplication.Controllers;
using CQRSWebApplication.DTOs;

namespace Test.CQRSWebApplication.Controllers;

public class CreateUserControllerTests
{
    [Fact]
    public void CreateUserIsNotImplemented()
    {
        var createUSerController = new CreateUserController();
        var fooUSer = new User(1);
        Action executeMethod = () => createUSerController.Execute(fooUSer);

        var exception = Assert.Throws<NotImplementedException>(executeMethod);

        Assert.Equal("The method or operation is not implemented.", exception.Message);
        Assert.False(false);
    }
}

