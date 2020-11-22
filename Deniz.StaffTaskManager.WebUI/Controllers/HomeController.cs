using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Deniz.StaffTaskManager.WebUI.Controllers
{
    public class HomeController : Controller
    {
        ITaskService _taskService;
        public HomeController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}