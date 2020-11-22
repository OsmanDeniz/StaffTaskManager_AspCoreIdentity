using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        private readonly EfUrgencyRepository repository;
        public UrgencyManager()
        {
            repository = new EfUrgencyRepository();
        }
        public void Add(Urgency table)
        {
            repository.Add(table);
        }

        public List<Urgency> GetAll()
        {
            return repository.GetAll();
        }

        public Urgency GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(Urgency table)
        {
            repository.Remove(table);
        }

        public void Update(Urgency table)
        {
            repository.Update(table);
        }
    }
}
