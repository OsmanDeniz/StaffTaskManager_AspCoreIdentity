using System;
using System.Collections.Generic;
using System.Linq;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Contexts;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Interfaces;

namespace Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories
{
   public class EfGenericRepository<Table> : IGenericDal<Table> where Table : class, ITable, new()
    {
        public void Add(Table table)
        {
            using var context = new TaskContext();
            context.Set<Table>().Add(table);
            context.SaveChanges();
        }

        public List<Table> GetAll()
        {
            using var context = new TaskContext();
            return context.Set<Table>().ToList();
        }

        public Table GetById(int id)
        {
            using var context = new TaskContext();
            return context.Set<Table>().Find(id);
        }

        public void Remove(Table table)
        {
            using var context = new TaskContext();
            context.Set<Table>().Remove(table);
            context.SaveChanges();
        }

        public void Update(Table table)
        {
            using var context = new TaskContext();
            context.Set<Table>().Update(table);
            context.SaveChanges();
        }
    }
}
