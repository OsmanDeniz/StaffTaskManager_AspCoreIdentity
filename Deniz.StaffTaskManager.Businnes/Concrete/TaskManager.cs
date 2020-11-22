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
        public void Add(Task table)
        {
            _dal.Add(table);
        }

        public List<Task> GetAll()
        {
            return _dal.GetAll();
        }

        public Task GetById(int id)
        {
            return _dal.GetById(id);
        }

        public void Remove(Task table)
        {
            _dal.Remove(table);
        }

        public void Update(Task table)
        {
            _dal.Update(table);
        }
    }
}
