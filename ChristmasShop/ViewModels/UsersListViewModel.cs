using ChristmasShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.ViewModels
{
    public class UsersListViewModel
    {
        public IEnumerable<User> GetUsers { get; set; }
    }
}
