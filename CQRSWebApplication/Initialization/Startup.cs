using CQRSWebApplication.Common.CommandBus;

namespace CQRSWebApplication.Initialization;

public class Startup
{

    public void ConfigureService(IServiceCollection services)
    {
        services.Add(new ServiceDescriptor(typeof(ICommandBus), new FakeCommandBus()));
    }
}