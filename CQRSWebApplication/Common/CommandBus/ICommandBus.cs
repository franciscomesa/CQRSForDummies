using CQRSWebApplication.Commands;

namespace CQRSWebApplication.Common.CommandBus;

public interface ICommandBus
{
    void Send(CreateUserCommand createUserCommand);
}