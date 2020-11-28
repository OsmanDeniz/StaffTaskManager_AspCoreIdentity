using System.ComponentModel.DataAnnotations;

namespace Deniz.StaffTaskManager.WebUI.Models
{
    public class AppUserSignInViewModel
    {
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        [Display(Name = "Kullanici Adi")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Bu alan bos gecilemez")]
        public string Password { get; set; }

        [Display(Name = "Beni hatirla")]
        public bool RememberMe { get; set; }
    }
}
