using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDAL _appUserDAL;
        public AppUserManager(IAppUserDAL appUserDAL)
        {
            _appUserDAL = appUserDAL;
        }
        public List<AppUser> GetNonAdmin()
        {
            return _appUserDAL.GetNonAdmin();
        }
    }
}
