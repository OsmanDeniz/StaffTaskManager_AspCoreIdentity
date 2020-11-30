using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.WebUI.Areas.Admin.Models
{
    public class TaskListAllViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_Date { get; set; }

        public Urgency Urgency { get; set; }

        public AppUser AppUser { get; set; }

        public List<Report> Reports { get; set; }

    }
}
