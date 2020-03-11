using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WBK.Models.Create;

namespace WBK.Controllers
{
    public class CreateController : Controller
    {
        [HttpGet]
        public IActionResult Survey()
        {
            CreateSurveyViewModel model = new CreateSurveyViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Survey(CreateSurveyViewModel model)
        {
            double test = Convert.ToDouble(model.StartLocationLong.Replace('.', ','));
            return View();
        }
    }
}