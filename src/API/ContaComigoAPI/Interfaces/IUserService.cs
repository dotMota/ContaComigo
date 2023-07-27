using ContaComigoAPI.Models;

namespace ContaComigoAPI.Interfaces
{
    public interface IUserService
    {
        UserModel CreateUser(UserModel user);

    }
}
