using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Entities.Interfaces;

namespace Deniz.StaffTaskManager.Entities.Concrete
{
    public class Task : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime Created_Date { get; set; } = DateTime.Now;

        public int? AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }

        public List<Report> Reports { get; set; }
    }
}
