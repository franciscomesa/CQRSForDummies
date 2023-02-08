using CQRSWebApplication.Controllers;

namespace Test.CQRSWebApplication.Controllers;

public class CreateUserControllerTests
{
    [Fact]
    public void CreateUserIsNotImplemented()
    {
        var createUSerController = new CreateUserController();
        Action executeMethod = () => createUSerController.Execute();

        var exception = Assert.Throws<NotImplementedException>(executeMethod);

        Assert.Equal("The method or operation is not implemented.", exception.Message);
        Assert.False(false);
        
        
    }
}