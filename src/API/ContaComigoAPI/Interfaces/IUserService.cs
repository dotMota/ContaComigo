using System.Threading.Tasks;
using ContaComigoAPI.Models;

namespace ContaComigoAPI.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> CreateUserAsync(UserModel user);
    }
}
