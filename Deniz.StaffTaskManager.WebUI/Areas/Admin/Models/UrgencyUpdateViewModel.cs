using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deniz.StaffTaskManager.WebUI.Areas.Admin.Models
{
    public class UrgencyUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Bu alan bos gecilemez")]
        [Display(Name = "Acileyet Durumu ")]
        public string UrgencyLevel { get; set; }
    }
}
