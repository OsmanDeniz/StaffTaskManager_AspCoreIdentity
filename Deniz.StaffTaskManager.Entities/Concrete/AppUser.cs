using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Deniz.StaffTaskManager.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
