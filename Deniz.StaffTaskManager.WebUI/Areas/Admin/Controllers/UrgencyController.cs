using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;
using Deniz.StaffTaskManager.WebUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Deniz.StaffTaskManager.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UrgencyController : Controller
    {
        private readonly IUrgencyService _urgencyService;
        public UrgencyController(IUrgencyService urgencyService)
        {
            _urgencyService = urgencyService;
        }

        public IActionResult Index()
        {
            List<Urgency> urgencies = _urgencyService.GetAll();
            List<UrgencyListViewModel> model = new List<UrgencyListViewModel>();
            foreach (var item in urgencies)
            {
                UrgencyListViewModel viewModel = new UrgencyListViewModel();
                viewModel.Id = item.Id;
                viewModel.UrgancyLevel = item.UrgancyLevel;

                model.Add(viewModel);
            }
            return View(model);
        }

        public IActionResult AddUrgency()
        {
            return View(new UrgencyAddViewModel());
        } 
        [HttpPost]
        public IActionResult AddUrgency(UrgencyAddViewModel model)
        {
            if (ModelState.IsValid)
            {
               _urgencyService.Add(new Urgency()
                {
                    UrgancyLevel = model.UrgencyLevel
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}