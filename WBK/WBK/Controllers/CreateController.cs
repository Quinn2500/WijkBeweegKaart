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
            SurveyViewModel model = new SurveyViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Survey(SurveyViewModel model)
        {
            double test = Convert.ToDouble(model.StartLocationLong.Replace('.', ','));
            return View();
        }

        [HttpGet]
        public IActionResult Pages()
        {
            PagesViewModel model = CreateEmptyModel();


            return View(model);
        }

        [HttpPost]
        public IActionResult Pages(PagesViewModel model)
        {
            
            return View();
        }

        private PagesViewModel CreateEmptyModel()
        {
            PagesViewModel model = new PagesViewModel { PagesList = new List<PageViewModel>() };
            model.PagesList.Add(new PageViewModel());
            model.PagesList[0].Questions = new List<QuestionViewModel>();
            model.PagesList[0].Questions.Add(new QuestionViewModel());
            model.PagesList[0].Questions[0].Options = new List<MultipleChoiceOptionViewModel>();
            model.PagesList[0].Questions[0].Options.Add(new MultipleChoiceOptionViewModel());
            return model;
        }
    }
}