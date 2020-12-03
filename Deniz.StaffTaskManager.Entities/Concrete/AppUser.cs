using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Deniz.StaffTaskManager.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }

        public List<Task_Entity> Tasks { get; set; }
    }
}
