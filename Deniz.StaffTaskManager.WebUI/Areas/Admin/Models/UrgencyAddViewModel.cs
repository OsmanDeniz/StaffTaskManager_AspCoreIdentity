using System.ComponentModel.DataAnnotations;

namespace Deniz.StaffTaskManager.WebUI.Areas.Admin.Models
{
    public class UrgencyAddViewModel
    {
        [Display(Name = "Aciliyet Durumu")]
        [Required(ErrorMessage = "Bu alan bos olamaz")]
        public string UrgencyLevel { get; set; }
    }
}
