using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Models
{
    public class User
    {
        public int ID { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Введите пароль")]
        public string Password { get; set; }

        public byte[] salt { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина email должна быть от 3 до 40 символов")]
        public string Email { get; set; }

        public bool Unblocked { get; set; }

        public int? RoleId { get; set; }

        public Role Role { get; set; }
    }

    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IEnumerable<User> Users { get; set; }

    }
}
