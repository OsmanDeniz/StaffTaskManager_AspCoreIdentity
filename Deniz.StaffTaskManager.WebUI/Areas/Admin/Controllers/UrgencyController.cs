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
            TempData["active"] = "urgency";
            List<Urgency> urgencies = _urgencyService.GetAll();
            List<UrgencyListViewModel> model = new List<UrgencyListViewModel>();
            foreach (var item in urgencies)
            {
                UrgencyListViewModel viewModel = new UrgencyListViewModel();
                viewModel.Id = item.Id;
                viewModel.UrgencyLevel = item.UrgencyLevel;

                model.Add(viewModel);
            }
            return View(model);
        }

        public IActionResult AddUrgency()
        {
            TempData["active"] = "urgency";
            return View(new UrgencyAddViewModel());
        }
        [HttpPost]
        public IActionResult AddUrgency(UrgencyAddViewModel model)
        {
            TempData["active"] = "urgency";
            if (ModelState.IsValid)
            {
                _urgencyService.Add(new Urgency()
                {
                    UrgencyLevel = model.UrgencyLevel
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult UpdateUrgency(int id)
        {
            TempData["active"] = "urgency";
            var urgency = _urgencyService.GetById(id);
            UrgencyUpdateViewModel model = new UrgencyUpdateViewModel
            {
                Id = urgency.Id,
                UrgencyLevel = urgency.UrgencyLevel
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateUrgency(UrgencyUpdateViewModel model)
        {
            TempData["active"] = "urgency";
            if (ModelState.IsValid)
            {
                _urgencyService.Update(new Urgency
                {
                    Id = model.Id,
                    UrgencyLevel = model.UrgencyLevel
                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}