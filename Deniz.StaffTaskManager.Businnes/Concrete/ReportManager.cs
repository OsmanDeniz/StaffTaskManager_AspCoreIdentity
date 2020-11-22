using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly EfReportRepository repository;
        public ReportManager()
        {
            repository = new EfReportRepository();
        }
        public void Add(Report table)
        {
            repository.Add(table);
        }

        public List<Report> GetAll()
        {
            return repository.GetAll();
        }

        public Report GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(Report table)
        {
            repository.Remove(table);
        }

        public void Update(Report table)
        {
            repository.Update(table);
        }
    }
}
