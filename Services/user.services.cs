using InventoryManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Data;
namespace InventoryManagementSystem.Services
{
    class UserService
    {
        InventoryDbContext context;
        public UserService()
        {
            context = new InventoryDbContext();
        }
        public User getUserByID(int id)
        {
            return context.Users.FirstOrDefault(x => x.Id == id);
        }
       

        public List<User> getAllUsers()
        {
            return context.Users.ToList();
        }
        public void addUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void updateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void deleteUser(User user)
        {
            context.Users.Remove(user);
            context.SaveChanges();
        }

    }
}
