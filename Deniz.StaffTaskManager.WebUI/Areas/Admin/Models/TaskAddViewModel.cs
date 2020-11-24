using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deniz.StaffTaskManager.WebUI.Areas.Admin.Models
{
    public class TaskAddViewModel
    {
        [Required(ErrorMessage ="Bu alan bos gecilemez.")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0,int.MaxValue,ErrorMessage ="Bir aciliyet durumu seciniz.")]
        public int UrgencyId { get; set; }
    }
}
