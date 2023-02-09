using CQRSWebApplication.Commands;
using CQRSWebApplication.Common.CommandBus;
using CQRSWebApplication.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWebApplication.Controllers;

[ApiController]
[Route("api/user")]
public class CreateUserController: ControllerBase
{
    private readonly ICommandBus commandBus;
    
    public CreateUserController()
    {
        this.commandBus = new FakeCommandBus();
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] CreateUserCommand createUserCommand)
    {
        return this.Ok(createUserCommand);
    }
}



    // public void Execute(User fooUSer)
    // {
    //     var createUserCommand = new CreateUserCommand(2);
    //     commandBus.Send(createUserCommand);
    //
    //     throw new NotImplementedException();
    // }
