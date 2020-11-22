﻿using System;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfUrgencyRepository : EfGenericRepository<Urgency>, IUrgencyDAL
    {
    }
}
