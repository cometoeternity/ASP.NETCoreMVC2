using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreMVC2.Models
{
    public class Guests
    {
        [Required(ErrorMessage ="Пожалуйста, введите имя")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Пожалуйста, введите свою электронную почту")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Это на похоже на электронную почту!")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Пожалуйста, введите номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage ="Пожалуйста, укажите, будете ли присутствовать")]
        public bool? WillAttend { get; set; }
    }
}
