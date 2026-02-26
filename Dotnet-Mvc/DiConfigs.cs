using Dotnet_Mvc.Services;
using Dotnet_Mvc.Services.Interface;

namespace Dotnet_Mvc;

public static class DiConfigs
{
    public static void ConfigureServices(this IServiceCollection service)
    {
        service.AddScoped<IUserService, UserService>();
    }
}