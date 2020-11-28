using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskDal _dal;
        public TaskManager(ITaskDal dal)
        {
            _dal = dal;
        }
        public void Add(Task_Entity table)
        {
            _dal.Add(table);
        }

        public List<Task_Entity> GetAll()
        {
            return _dal.GetAll();
        }

        public List<Task_Entity> GetAllUncompletedTasks()
        {
            return _dal.GetAllUncompletedTasks();
        }

        public Task_Entity GetById(int id)
        {
            return _dal.GetById(id);
        }

        public void Remove(Task_Entity table)
        {
            _dal.Remove(table);
        }

        public void Update(Task_Entity table)
        {
            _dal.Update(table);
        }
    }
}
