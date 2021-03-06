﻿using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Entities.Interfaces;

namespace Deniz.StaffTaskManager.Entities.Concrete
{
    public class Urgency : ITable
    {
        public int Id { get; set; }
        public string UrgencyLevel { get; set; }

        public List<Task_Entity> Tasks { get; set; }
    }
}
