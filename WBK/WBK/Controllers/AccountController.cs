using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;
using WBK.Models;
using WBK.Models.Account;

namespace WBK.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountLogic _accountLogic = new AccountLogic();

        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpGet]
        public IActionResult LogOut()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Email")))
            {
                return StatusCode(401);
            }
            HttpContext.Session.Remove("Email");
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Register()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Email")))
            {
                return StatusCode(401);
            }
            RegisterViewModel model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Employee employee = _accountLogic.LoginUser(model.Email, model.Password);

            if (employee is null)
            {
                ModelState.AddModelError("Error", "Combinatie is niet bekend!");
                return View(model);
            }

            HttpContext.Session.SetString("Email", model.Email);
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Email")))
            {
                return StatusCode(401);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Employee newEmployee = new Employee
            {
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName, 
                PrePesition = model.PrePesition
            };

            _accountLogic.RegisterEmployee(newEmployee, model.ConfirmPassword);

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
