using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DataModels.Questions;
using Logic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WBK.Models.Create;

namespace WBK.Controllers
{
    public class CreateController : Controller
    {
        private Survey surveyModel = new Survey();
        private readonly SurveyLogic _logic = new SurveyLogic();
        [HttpGet]
        public IActionResult Survey()
        {
            SurveyViewModel model = new SurveyViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Survey(SurveyViewModel model)
        {
            surveyModel.Title = model.Title;
            surveyModel.Description = model.Description;
            surveyModel.Owner = "test@test.nl";
            surveyModel.EndDate = model.EndDate;
            double longitude = Convert.ToDouble(model.StartLocationLong.Replace('.', ','));
            double latitude = Convert.ToDouble(model.StartLocationLat.Replace('.', ','));
            Location startLocation = new Location(latitude,longitude);
            surveyModel.StartLocation = startLocation;
            surveyModel.DateOfCreation = DateTime.Today;
            return RedirectToAction("Pages");
        }

        [HttpGet]
        public IActionResult Pages()
        {
            PagesViewModel model = CreateEmptyPageModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Pages(PagesViewModel model)
        {
            List<Page> pages = new List<Page>();
            foreach (PageViewModel pageView in model.PagesList)
            {
                Page page = new Page
                {
                    Title = pageView.Title,
                    Description = pageView.Description,
                    Questions = new List<Question>()
                    
                };

                foreach (QuestionViewModel questionView in pageView.Questions)
                {
                    switch (questionView.Type)
                    {
                        case TypeEnum.GeoVraag:
                            GeoQuestion geoQuestion = new GeoQuestion();
                            geoQuestion.Value = questionView.Title;
                            geoQuestion.Description = questionView.Description;
                            geoQuestion.Category = questionView.Category;
                            geoQuestion.Type = questionView.Type;
                            geoQuestion.TypeOfMarker = questionView.GeoType;
                            page.Questions.Add(geoQuestion);
                            break;

                        case TypeEnum.OpenVraag:
                            OpenQuestion openQuestion = new OpenQuestion();
                            openQuestion.Value = questionView.Title;
                            openQuestion.Description = questionView.Description;
                            openQuestion.Category = questionView.Category;
                            openQuestion.Type = questionView.Type;
                            page.Questions.Add(openQuestion);
                            break;

                        case TypeEnum.NummerVraag:
                            NumberQuestion numberQuestion = new NumberQuestion();
                            numberQuestion.Value = questionView.Title;
                            numberQuestion.Description = questionView.Description;
                            numberQuestion.Category = questionView.Category;
                            numberQuestion.Type = questionView.Type;
                            numberQuestion.Maximum = questionView.MaxValue;
                            numberQuestion.Minimum = questionView.MinValue;
                            page.Questions.Add(numberQuestion);
                            break;

                        case TypeEnum.SliderVraag:
                            SliderQuestion sliderQuestion = new SliderQuestion();
                            sliderQuestion.Value = questionView.Title;
                            sliderQuestion.Description = questionView.Description;
                            sliderQuestion.Category = questionView.Category;
                            sliderQuestion.Type = questionView.Type;
                            sliderQuestion.MaxValueText = questionView.SliderMaxText;
                            sliderQuestion.MinValueText = questionView.SliderMinText;
                            sliderQuestion.Scale = questionView.SliderScaleVal;
                            page.Questions.Add(sliderQuestion);
                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceQuestion multipleChoiceQuestion = new MultipleChoiceQuestion();
                            multipleChoiceQuestion.Value = questionView.Title;
                            multipleChoiceQuestion.Description = questionView.Description;
                            multipleChoiceQuestion.Category = questionView.Category;
                            multipleChoiceQuestion.Type = questionView.Type;
                            multipleChoiceQuestion.AllowMutlipleAnwsers = questionView.AllowMultipleAnswers;
                            multipleChoiceQuestion.Options = new List<MultipleChoiceOption>();
                            foreach (MultipleChoiceOptionViewModel optionView in questionView.Options)
                            {
                                MultipleChoiceOption option = new MultipleChoiceOption
                                {
                                    Value = optionView.Answer,
                                    Description = optionView.Description
                                };
                                multipleChoiceQuestion.Options.Add(option);
                            }
                            page.Questions.Add(multipleChoiceQuestion);
                            break;
                    }

                }
                pages.Add(page);
            }

            surveyModel.Pages = pages;
            _logic.InsertSurvey(surveyModel);
            return View();
        }

        private PagesViewModel CreateEmptyPageModel()
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