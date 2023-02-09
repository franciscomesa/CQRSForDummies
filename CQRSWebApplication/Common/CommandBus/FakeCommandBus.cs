using CQRSWebApplication.Commands;

namespace CQRSWebApplication.Common.CommandBus;

public class FakeCommandBus : ICommandBus
{
    public void Send(CreateUserCommand createUserCommand)
    {
        throw new NotImplementedException();
    }
}