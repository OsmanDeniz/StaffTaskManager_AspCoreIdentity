using System;
using System.Collections.Generic;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDAL _reportDAL;
        public ReportManager(IReportDAL reportDAL)
        {
            _reportDAL = reportDAL;
        }
        public void Add(Report table)
        {
            _reportDAL.Add(table);
        }

        public List<Report> GetAll()
        {
            return _reportDAL.GetAll();
        }

        public Report GetById(int id)
        {
            return _reportDAL.GetById(id);
        }

        public void Remove(Report table)
        {
            _reportDAL.Remove(table);
        }

        public void Update(Report table)
        {
            _reportDAL.Update(table);
        }
    }
}
