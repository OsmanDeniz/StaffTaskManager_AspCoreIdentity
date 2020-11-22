using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    class TaskManager : ITaskService
    {
        private readonly EfTaskRepository repository;
        public TaskManager()
        {
            repository = new EfTaskRepository();
        }
        public void Add(Task table)
        {
            repository.Add(table);
        }

        public List<Task> GetAll()
        {
            return repository.GetAll();
        }

        public Task GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(Task table)
        {
            repository.Remove(table);
        }

        public void Update(Task table)
        {
            repository.Update(table);
        }
    }
}
