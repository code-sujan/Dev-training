using Dotnet_Mvc.Dtos;
using Dotnet_Mvc.Enums;
using Dotnet_Mvc.Models;
using Dotnet_Mvc.Services.Interface;
using Dotnet_Mvc.ViewModel;

namespace Dotnet_Mvc.Services;

public class UserService : IUserService
{
    private static List<UserModel> _list = new List<UserModel>();

    public async Task<UserModel> AddUserAsync(NewUseDto dto)
    {
        var id = Guid.NewGuid();
        var model = new UserModel
        {
            Id = id,
            UserName = dto.UserName,
            Email = dto.Email,
            Address = dto.Address,
            Password = dto.Password,
        };
        _list.Add(model);
        return model;
    }

    public void EditUserAsync(EditUserVm vm)
    {
        var details = _list.FirstOrDefault(x => x.Id == vm.UserId);
        if (details == null)
        {
            throw new Exception("User not found");
        }
        else
        {
            details.UserName = vm.UserName;
            details.Email = vm.Email;
            details.Address = vm.Address;
        }
    }

    public void RemoveUserAsync(Guid id)
    {
        var userData = _list.FirstOrDefault(x => x.Id == id);
        if (userData != null)
        {
            userData.Status = (int)StatusEnum.Inactive;
        }
        else
        {
            throw new Exception("User not found");
        }
    }
}