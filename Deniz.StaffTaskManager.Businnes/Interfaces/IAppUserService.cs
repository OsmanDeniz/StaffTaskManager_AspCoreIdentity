using System;
using System.Collections.Generic;
using System.Text;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Interfaces
{
    public interface IAppUserService
    {
        List<AppUser> GetNonAdmin();
    }
}
