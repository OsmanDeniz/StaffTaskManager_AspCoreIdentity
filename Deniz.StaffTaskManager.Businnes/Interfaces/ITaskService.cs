using System;
using System.Collections.Generic;
using System.Text;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.Businnes.Interfaces
{
    public interface ITaskService : IGenericService<Task_Entity>
    {
        List<Task_Entity> GetAllUncompletedTasks();
        List<Task_Entity> GetDataWithAllTables();
        Task_Entity GetViewById(int id);
    }
}
