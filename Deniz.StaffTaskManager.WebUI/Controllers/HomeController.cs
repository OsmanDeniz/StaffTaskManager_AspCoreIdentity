using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;
using Deniz.StaffTaskManager.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Deniz.StaffTaskManager.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signManager;
        public HomeController(ITaskService taskService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _taskService = taskService;
            _userManager = userManager;
            _signManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AppUserSignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Username);
                if (user != null)
                {
                    var identityResult = await _signManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {

                        var userRole = await _userManager.GetRolesAsync(user);
                        if (userRole.Contains("Admin"))
                        {
                            return RedirectToAction("index", "home", new { area = "Admin" });
                        }
                        else
                        {
                            return RedirectToAction("index", "home", new { area = "Member" });
                        }
                    }
                }
                ModelState.AddModelError("", "Kullanici adi veya sifre hatali.");
            }
            return View("Index", model);
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    UserName = model.Username,
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    var userAddRole = await _userManager.AddToRoleAsync(user, "Member");
                    if (userAddRole.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var item in userAddRole.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(model);
        }
    }
}