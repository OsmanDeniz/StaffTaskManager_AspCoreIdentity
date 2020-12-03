using System;
using System.Collections.Generic;
using System.Text;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.DataAccess.Interfaces
{
    public interface IAppUserDAL
    {
        List<AppUser> GetNonAdmin();
    }
}
