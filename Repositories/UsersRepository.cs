using crudWithInterfacesUsingWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace crudWithInterfacesUsingWebAPI.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _dbContext;

        public UsersRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
         
        public IEnumerable<Users> GetUsers()
        {
            return _dbContext.Users.ToList();
        }

        public Users GetUserById(int id)
        {
            //return _dbContext.Users.FirstOrDefault(p => p.UserID == id);
            return _dbContext.Users.Where(p => p.UserID == id).FirstOrDefault();
        }

        public Users CreateUser(Users user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public void UpdateUser(int id, Users updatedUser)
        {
            var userToUpdate = _dbContext.Users.FirstOrDefault(p => p.UserID == id);
            if (userToUpdate != null)
            {
                userToUpdate.FirstName = updatedUser.FirstName;
                userToUpdate.LastName = updatedUser.LastName;
                userToUpdate.EmailAddress = updatedUser.EmailAddress;
                userToUpdate.City = updatedUser.City;
                _dbContext.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            var userToDelete = _dbContext.Users.FirstOrDefault(p => p.UserID == id);
            if (userToDelete != null)
            {
                _dbContext.Users.Remove(userToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}

