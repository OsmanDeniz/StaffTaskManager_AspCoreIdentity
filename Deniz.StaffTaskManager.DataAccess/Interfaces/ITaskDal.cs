using System.Collections.Generic;
using Deniz.StaffTaskManager.Entities.Concrete;

namespace Deniz.StaffTaskManager.DataAccess.Interfaces
{
    public interface ITaskDal : IGenericDal<Task>
    {
        List<Task> GetAllUncompletedTasks();
    }
}
