using System;
using Deniz.StaffTaskManager.Entities.Interfaces;

namespace Deniz.StaffTaskManager.Entities.Concrete
{
    public class Report : ITable
    {
        public int Id { get; set; }
        public string ReportStatus { get; set; }
        public string ReportDetails { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }

    }
}
