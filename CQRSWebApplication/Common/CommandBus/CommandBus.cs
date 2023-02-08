using CQRSWebApplication.Commands;

namespace CQRSWebApplication.Common.CommandBus;

public interface CommandBus
{
    void Send(CreateUserCommand createUserCommand);
}
