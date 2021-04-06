using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PsyAgregator.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Пожалуйста, введите логин")]
        public string UserName { get; set; }

        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Пожалуйста, введите пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить")]
        public bool RememberMe { get; set; }
    }
}
