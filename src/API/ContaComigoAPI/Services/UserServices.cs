using ContaComigoAPI.Interfaces;
using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public class UserServices : IUserService
    {
        private List<UserModel> _users;

        public UserServices()
        {
            _users = new List<UserModel>();
        }

        public UserModel CreateUser(UserModel user)
        {
            user.UserId = Guid.NewGuid();
            _users.Add(user);

            // [ ] Insert new user in DB
            return user;
        }
        // [ ] RemoveUserByID
        // [ ] UpdateUserByID
        // [ ] GetUserByID
    }
}
