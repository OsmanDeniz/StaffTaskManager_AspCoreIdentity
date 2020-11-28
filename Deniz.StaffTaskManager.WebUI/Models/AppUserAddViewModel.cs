using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deniz.StaffTaskManager.WebUI.Models
{
    public class AppUserAddViewModel
    {
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        [Display(Name = "Kullanici Adi")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Sifre Tekrar")]
        [Compare("Password", ErrorMessage = "Parolalar eslesmiyor")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "Gecersiz Email Adresi Formati")]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        public string Email { get; set; }

        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        public string Name { get; set; }

        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        public string Surname { get; set; }

    }
}
