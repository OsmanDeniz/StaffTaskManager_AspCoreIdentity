using System.Collections.Generic;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.DataAccess.Interfaces
{
    public interface ITaskDal : IGenericDal<Task_Entity>
    {
        List<Task_Entity> GetAllUncompletedTasks();
        List<Task_Entity> GetDataWithAllTables();
        Task_Entity GetViewById(int id);
    }
}
