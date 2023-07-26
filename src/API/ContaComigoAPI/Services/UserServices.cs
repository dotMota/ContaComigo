using System;
using System.Collections.Generic;
using System.Linq;
using ContaComigoAPI.Models;

namespace ContaComigoAPI.Services
{
    public class UserServices : IUserService
    {
        private List<User> userList;
        private int nextUserId;

        public UserServices()
        {
            userList = new List<User>();
            nextUserId = 1;
        }

        public User CreateUser(User user)
        {
            user.IdUser = nextUserId;
            nextUserId++;
            userList.Add(user);
            
            return user;
        }

        public void RemoveUser(int userId)
        {
            var userToRemove = userList.Find(u => u.IdUser == userId);
            if (userToRemove != null)
            {
                userList.Remove(userToRemove);
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public User UpdateUser(User user)
        {
            var existingUser = userList.Find(u => u.IdUser == user.IdUser);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Document = user.Document;
                existingUser.Password = user.Password;
                existingUser.Phone = user.Phone;
                return existingUser;
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public User GetUserById(int userId)
        {
            var user = userList.Find(u => u.IdUser == userId);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("User not found.");
            }
        }
    }
}
