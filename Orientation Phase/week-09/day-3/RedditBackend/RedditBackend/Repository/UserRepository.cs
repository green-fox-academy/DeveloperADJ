using RedditBackend.Entities;
using RedditBackend.Models;
using RedditBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Repository
{
    public class UserRepository : ICRUDRepository<User>, IUserRepository
    {
        private RedditContext userContext;

        public UserRepository(RedditContext userContext)
        {
            this.userContext = userContext;
        }

        public User Create(User user)
        {
            userContext.Users.Add(user);
            userContext.SaveChanges();
            return user;
        }

        private User GetUserFromId(int id)
        {
            return userContext.Users.FirstOrDefault(x => x.Id == id);
        }

        public User Delete(int id)
        {
            User deletedUser = GetUserFromId(id);
            userContext.Remove(GetUserFromId(id));
            userContext.SaveChanges();

            return deletedUser;
        }

        public List<User> Read()
        {
            return userContext.Users.ToList();
        }

        public User Update(int id, User updatedClass)
        {
            throw new NotImplementedException();
        }
    }
}
