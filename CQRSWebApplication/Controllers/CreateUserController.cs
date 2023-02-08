using CQRSWebApplication.Commands;
using CQRSWebApplication.Common.CommandBus;
using CQRSWebApplication.DTOs;

namespace CQRSWebApplication.Controllers;

public class CreateUserController
{
    private readonly CommandBus commandBus;

    public CreateUserController(CommandBus commandBus)
    {
        this.commandBus = commandBus;
    }

    public void Execute(User fooUSer)
    {
        var createUserCommand = new CreateUserCommand(fooUSer.Id);
        commandBus.Send(createUserCommand);

        throw new NotImplementedException();
    }
}