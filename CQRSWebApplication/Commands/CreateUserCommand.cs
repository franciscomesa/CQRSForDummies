namespace CQRSWebApplication.Commands;

public class CreateUserCommand
{
    public int Id { get; }
    public CreateUserCommand(int id)
    {
        Id = id;
    }
}