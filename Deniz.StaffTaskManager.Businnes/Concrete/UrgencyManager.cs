using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        private readonly IUrgencyDAL _urgencyDAL;
        public UrgencyManager(IUrgencyDAL urgencyDAL)
        {
            _urgencyDAL = urgencyDAL;
        }
        public void Add(Urgency table)
        {
            _urgencyDAL.Add(table);
        }

        public List<Urgency> GetAll()
        {
            return _urgencyDAL.GetAll();
        }

        public Urgency GetById(int id)
        {
            return _urgencyDAL.GetById(id);
        }

        public void Remove(Urgency table)
        {
            _urgencyDAL.Remove(table);
        }

        public void Update(Urgency table)
        {
            _urgencyDAL.Update(table);
        }
    }
}
