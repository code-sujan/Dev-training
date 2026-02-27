using Dotnet_Mvc.Entities;

namespace Dotnet_Mvc.Repository.Interface;

public interface IUserRepo
{
    void Create(User user);
}