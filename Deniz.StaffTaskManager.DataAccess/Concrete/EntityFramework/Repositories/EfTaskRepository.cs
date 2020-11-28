﻿using System;
using System.Collections.Generic;
using System.Linq;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Contexts;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfTaskRepository : EfGenericRepository<Task_Entity>, ITaskDal
    {
        public List<Task_Entity> GetAllUncompletedTasks()
        {
            using (var context = new TaskContext())
            {
                return context.Tasks.Include(i => i.Urgency).Where(i => !i.Status).OrderByDescending(i => i.Created_Date).ToList();
            }
        }
    }
}
