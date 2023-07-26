using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public interface IUserService
    {
        User CreateUser(User user);
        void RemoveUser(int userId);
        User UpdateUser(User user);
        User GetUserById(int userId);
    }
}
