using System.Collections.Generic;
using Deniz.StaffTaskManager.Entities.Interfaces;

namespace Deniz.StaffTaskManager.DataAccess.Interfaces
{
    public interface IGenericDal<MyTable> where MyTable : class, ITable, new()
    {
        void Add(MyTable table);
        void Remove(MyTable table);
        void Update(MyTable table);
        MyTable GetById(int id);
        List<MyTable> GetAll();
    }
}
