using ChristmasShop.Data;
using ChristmasShop.Data.interfaces;
using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Repository
{
    public class UserRepository : IUsers
    {
        private readonly AppDBContent appDBContent;


        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<User> AllUsers => appDBContent.User;


        public User ConfirmUser(string name, string pas) => appDBContent.User.FirstOrDefault(u => u.Email == name && u.Password == pas);

        public void CreateUser(User user) => appDBContent.User.Add(user);

        public int GetUserIdByName(string name) => appDBContent.User.FirstOrDefault(u => u.Email == name).ID;


        public void DeleteUser(User user) => appDBContent.User.Remove(user);

        public User GetUser(int id) => appDBContent.User.FirstOrDefault(u => u.ID == id);

        public void SaveDB() => appDBContent.SaveChanges();

        public User WithSameName(string name) => appDBContent.User.FirstOrDefault(u => u.Email == name);
    }
}
