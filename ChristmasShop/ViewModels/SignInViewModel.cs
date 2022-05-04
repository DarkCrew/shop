using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.ViewModels
{
    public class SignInViewModel
    {
        [Display(Name = "Введите email")]
        [StringLength(40)]
        [Required(ErrorMessage = "Длина email должна быть от 3 до 40 символов")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
