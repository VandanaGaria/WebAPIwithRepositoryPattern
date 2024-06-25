using crudWithInterfacesUsingWebAPI.Models;
using System.Collections.Generic;

namespace crudWithInterfacesUsingWebAPI.Repositories
{
    public interface IUsersRepository
    {
        IEnumerable<Users> GetUsers();
        Users GetUserById(int id);
        Users CreateUser(Users user);
        void UpdateUser(int id, Users updatedUser);
        void DeleteUser(int id); 
    }
}
