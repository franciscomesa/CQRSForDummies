using CQRSWebApplication.Controllers;

namespace Test.CQRSWebApplication.Controllers;

public class CreateUserControllerTests
{
    [Fact]
    public void CreateUserIsNotImplemented()
    {
        var createUSerController = new CreateUserController();
        Action executeMethod = () => createUSerController.Execute();  // Lambda de toda la vida
        void ExecuteMethod() => createUSerController.Execute();       // Local function

        var exception = Assert.Throws<NotImplementedException>((Action)ExecuteMethod);

        Assert.Equal("The method or operation is not implemented.", exception.Message);
        Assert.False(false);
    }
}