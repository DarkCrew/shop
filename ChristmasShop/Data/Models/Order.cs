using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина имени должна быть от 3 до 25 символов")]
        public string name { get; set; }

        [Display(Name = "Введите фамилию")]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина фамилии должна быть от 3 до 25 символов")]
        public string surname { get; set; }

        [Display(Name = "Введите адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса должна быть от 3 до 35 символов")]
        public string address { get; set; }

        [Display(Name = "Введите телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15)]
        [Required(ErrorMessage = "Длина телефона должна быть от 3 до 15 символов")]
        public string phone { get; set; }

        [Display(Name = "Введите email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длина email должна быть от 3 до 25 символов")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)] //don't show this line, when someone fill the form
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}
