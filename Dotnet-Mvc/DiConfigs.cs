using Dotnet_Mvc.Services;
using Dotnet_Mvc.Services.Interface;

namespace Dotnet_Mvc;

public static class DiConfigs
{
    public static void UseApplicationServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUserService, UserService>();
    }
}