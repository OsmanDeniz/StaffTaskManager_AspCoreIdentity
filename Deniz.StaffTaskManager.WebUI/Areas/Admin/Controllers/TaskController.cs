using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;
using Deniz.StaffTaskManager.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Deniz.StaffTaskManager.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IUrgencyService _urgencyService;
        public TaskController(ITaskService taskService, IUrgencyService urgencyService)
        {
            _taskService = taskService;
            _urgencyService = urgencyService;
        }
        public IActionResult Index()
        {
            TempData["active"] = "task";
            List<Task_Entity> tasks = _taskService.GetAllUncompletedTasks();
            List<TaskListViewModel> models = new List<TaskListViewModel>();
            foreach (var item in tasks)
            {
                TaskListViewModel model = new TaskListViewModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Status = item.Status,
                    Urgency = item.Urgency,
                    UrgencyId = item.UrgencyId,
                    Description = item.Description,
                    Created_Date = item.Created_Date
                };
                models.Add(model);
            }
            return View(models);
        }
        public IActionResult AddTask()
        {
            ViewBag.UrgencyList = (SelectList)new SelectList(_urgencyService.GetAll(), "Id", "UrgencyLevel");
            return View(new TaskAddViewModel());
        }

        [HttpPost]
        public IActionResult AddTask(TaskAddViewModel model)
        {
            TempData["active"] = "task";
            if (ModelState.IsValid)
            {
                _taskService.Add(new Task_Entity
                {
                    Description = model.Description,
                    Name = model.Name,
                    UrgencyId = model.UrgencyId
                });
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult UpdateTask(int id)
        {
            TempData["active"] = "task";
            var task = _taskService.GetById(id);
            TaskUpdateViewModel model = new TaskUpdateViewModel
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                UrgencyId = task.UrgencyId
            };

            ViewBag.Urgencies = new SelectList(_urgencyService.GetAll(), "Id", "UrgencyLevel", task.UrgencyId);
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateTask(TaskUpdateViewModel model)
        {
            TempData["active"] = "task";
            ViewBag.Urgencies = new SelectList(_urgencyService.GetAll(), "Id", "UrgencyLevel", model.UrgencyId);

            if (ModelState.IsValid)
            {
                _taskService.Update(new Task_Entity
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description,
                    UrgencyId = model.UrgencyId
                });
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult RemoveTask(int id)
        {
            _taskService.Remove(new Task_Entity { Id = id });
            return Json(null);
        }
    }
}