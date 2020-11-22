using System;
using System.Collections.Generic;
using System.Text;
using Deniz.StaffTaskManager.Entities.Interfaces;

namespace Deniz.StaffTaskManager.Businnes.Interfaces
{
    public interface IGenericService<MyTable> where MyTable : class, ITable, new()
    {
        void Add(MyTable table);
        void Remove(MyTable table);
        void Update(MyTable table);
        MyTable GetById(int id);
        List<MyTable> GetAll();
    }
}
