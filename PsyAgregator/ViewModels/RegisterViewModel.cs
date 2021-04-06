using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PsyAgregator.ViewModels
{
    public class RegisterViewModel:LoginViewModel
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Пожалуйста, введите свое имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Пожалуйста, введите свою фамилию")]
        public string LastName { get; set; }

        [Display(Name = "Номер телефона")]
        [Required(ErrorMessage = "Пожалуйста, введите номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Пожалйста, введите email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
