using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DataModels.Questions;
using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WBK.Models.Create;

namespace WBK.Controllers
{
    public class CreateController : Controller
    {
        private readonly SurveyLogic _logic = new SurveyLogic();

        [HttpGet]
        public IActionResult Survey(string title)
        {
            SurveyViewModel model;
            if (title != null)
            {
                Survey survey = _logic.GetSurvey(title);
                return View(ConvertModelToView(survey));
            }
            else
            {
                model = new SurveyViewModel { PagesList = CreateEmptyPageModel() };
                return View(model);
            }
            
        }

        [HttpPost]
        public IActionResult Survey(SurveyViewModel model)
        {

            _logic.InsertSurvey(ConvertViewToModel(model));
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult EditSurvey(string title)
        {
            Survey survey = _logic.GetSurvey(title);
            SurveyViewModel model = ConvertModelToView(survey);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditSurvey(SurveyViewModel model)
        {
            Survey surveyToUpdate = ConvertViewToModel(model);
            _logic.UpdateSurvey(surveyToUpdate);
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult DeleteSurvey(string title)
        {
            _logic.DeleteSurvey(HttpContext.Session.GetString("Email"), title);
            return RedirectToAction("Index", "Dashboard");
        }

        private List<PageViewModel> CreateEmptyPageModel()
        {
            List<PageViewModel> model = new List<PageViewModel>();
            model.Add(new PageViewModel());
            model[0].Questions = new List<QuestionViewModel>();
            model[0].Questions.Add(new QuestionViewModel());
            model[0].Questions[0].Options = new List<MultipleChoiceOptionViewModel>();
            model[0].Questions[0].Options.Add(new MultipleChoiceOptionViewModel());
            return model;
        }

        private Survey ConvertViewToModel(SurveyViewModel model)
        {
            Survey surveyModel = new Survey
            {
                Title = model.Title,
                Description = model.Description,
                Owner = HttpContext.Session.GetString("Email"),
                EndDate = DateTime.Parse(model.EndDate, CultureInfo.CreateSpecificCulture("nl-NL")),
                DateOfCreation = DateTime.Today,
                ImageUrl = model.ImageUrl
            };

            List<Page> pages = new List<Page>();
            foreach (PageViewModel pageView in model.PagesList)
            {
                Page page = new Page
                {
                    Id = pageView.Id,
                    Title = pageView.Title,
                    Description = pageView.Description,
                    Questions = new List<Question>(),
                    ImageUrl = pageView.ImageUrl

                };
                if (pageView.Questions != null)
                {
                    foreach (QuestionViewModel questionView in pageView.Questions)
                    {
                        questionView.Category = CategoryEnum.Algemeen;

                        switch (questionView.Type)
                        {
                            case TypeEnum.GeoVraag:

                                GeoQuestion geoQuestion = new GeoQuestion
                                {
                                    Id = questionView.Id,
                                    Value = questionView.Title,
                                    Description = questionView.Description,
                                    IsRequired = questionView.IsRequierd,
                                    Category = questionView.Category,
                                    Type = questionView.Type,
                                    ImageUrl = questionView.ImageUrl,
                                    TypeOfMarker = questionView.GeoType,
                                    StartLocation = null,
                                    Attribute = questionView.Attribute
                                };

                                if (!string.IsNullOrEmpty(questionView.StartLocationLat))
                                {
                                    Location startLocation = new Location(Convert.ToDouble(questionView.StartLocationLat.Replace('.', ',')), Convert.ToDouble(questionView.StartLocationLong.Replace('.', ',')), questionView.StartZoomLevel);
                                    geoQuestion.StartLocation = startLocation;
                                }
                                page.Questions.Add(geoQuestion);
                                break;

                            case TypeEnum.OpenVraag:
                                OpenQuestion openQuestion = new OpenQuestion
                                {
                                    Value = questionView.Title,
                                    Id = questionView.Id,
                                    Description = questionView.Description,
                                    IsRequired = questionView.IsRequierd,
                                    Category = questionView.Category,
                                    ImageUrl = questionView.ImageUrl,
                                    Type = questionView.Type,
                                    Attribute = questionView.Attribute
                                };
                                page.Questions.Add(openQuestion);
                                break;

                            case TypeEnum.NummerVraag:
                                NumberQuestion numberQuestion = new NumberQuestion
                                {
                                    Value = questionView.Title,
                                    Id = questionView.Id,
                                    Description = questionView.Description,
                                    IsRequired = questionView.IsRequierd,
                                    Category = questionView.Category,
                                    Type = questionView.Type,
                                    ImageUrl = questionView.ImageUrl,
                                    Maximum = questionView.MaxValue,
                                    Minimum = questionView.MinValue,
                                    Attribute = questionView.Attribute
                                };
                                page.Questions.Add(numberQuestion);
                                break;

                            case TypeEnum.SliderVraag:
                                SliderQuestion sliderQuestion = new SliderQuestion
                                {
                                    Value = questionView.Title,
                                    Id = questionView.Id,
                                    Description = questionView.Description,
                                    IsRequired = questionView.IsRequierd,
                                    Category = questionView.Category,
                                    Type = questionView.Type,
                                    ImageUrl = questionView.ImageUrl,
                                    MaxValueText = questionView.SliderMaxText,
                                    MinValueText = questionView.SliderMinText,
                                    Scale = questionView.SliderScaleVal,
                                    Attribute = questionView.Attribute
                                };
                                page.Questions.Add(sliderQuestion);
                                break;

                            case TypeEnum.MeerkeuzeVraag:
                                MultipleChoiceQuestion multipleChoiceQuestion = new MultipleChoiceQuestion
                                {
                                    Value = questionView.Title,
                                    Id = questionView.Id,
                                    Description = questionView.Description,
                                    IsRequired = questionView.IsRequierd,
                                    Category = questionView.Category,
                                    Type = questionView.Type,
                                    ImageUrl = questionView.ImageUrl,
                                    MaximumNumberOfAnswers = questionView.MaximumNumberOfAnswers,
                                    Options = new List<MultipleChoiceOption>(),
                                    Attribute = questionView.Attribute
                                };
                                foreach (MultipleChoiceOptionViewModel optionView in questionView.Options)
                                {
                                    MultipleChoiceOption option = new MultipleChoiceOption(optionView.Answer, optionView.Description, optionView.ImageUrl);
                                    multipleChoiceQuestion.Options.Add(option);
                                }
                                page.Questions.Add(multipleChoiceQuestion);
                                break;
                        }
                    }

                }
                pages.Add(page);
            }

            surveyModel.Pages = pages;
            return surveyModel;
        }

        private SurveyViewModel ConvertModelToView(Survey survey)
        {
            SurveyViewModel viewModel = new SurveyViewModel
            {
                Title = survey.Title,
                Description = survey.Description,
                EndDate = survey.EndDate.ToString(),
                PagesList = new List<PageViewModel>()
            };

            foreach (Page page in survey.Pages)
            {
                PageViewModel pageViewModel = new PageViewModel
                {
                    Id = page.Id,
                    Description = page.Description,
                    Title = page.Title,
                    Questions = new List<QuestionViewModel>()
                };

                foreach (Question question in page.Questions)
                {
                    QuestionViewModel questionView = new QuestionViewModel();

                    switch (question.Type)
                    {
                        case TypeEnum.GeoVraag:
                            GeoQuestion geoQuestion = question as GeoQuestion;                          
                            questionView = new QuestionViewModel
                            {
                                Id = question.Id,
                                Title = question.Value,
                                Description = question.Description,
                                Category = question.Category,
                                Type = question.Type,
                                GeoType = geoQuestion.TypeOfMarker
                            };
                            break;

                        case TypeEnum.NummerVraag:
                            NumberQuestion numberQuestion = question as NumberQuestion;
                            questionView = new QuestionViewModel
                            {
                                Id = question.Id,
                                Title = question.Value,
                                Description = question.Description,
                                Category = question.Category,
                                Type = question.Type,
                                MinValue = numberQuestion.Minimum,
                                MaxValue = numberQuestion.Maximum
                            };
                            break;

                        case TypeEnum.SliderVraag:
                            SliderQuestion sliderQuestion = question as SliderQuestion;
                            questionView = new QuestionViewModel
                            {
                                Id = question.Id,
                                Title = question.Value,
                                Description = question.Description,
                                Category = question.Category,
                                Type = question.Type,
                                SliderScaleVal = sliderQuestion.Scale,
                                SliderMaxText = sliderQuestion.MaxValueText,
                                SliderMinText = sliderQuestion.MinValueText
                            };
                            break;

                        case TypeEnum.OpenVraag:
                            questionView = new QuestionViewModel
                            {
                                Id = question.Id,
                                Title = question.Value,
                                Description = question.Description,
                                Category = question.Category,
                                Type = question.Type
                            };
                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceQuestion multipleChoiceQuestion = question as MultipleChoiceQuestion;
                            questionView = new QuestionViewModel
                            {
                                Id = question.Id,
                                Title = question.Value,
                                Description = question.Description,
                                Category = question.Category,
                                Type = question.Type,
                                MaximumNumberOfAnswers = multipleChoiceQuestion.MaximumNumberOfAnswers,
                                Options = new List<MultipleChoiceOptionViewModel>()
                            };
                            foreach (MultipleChoiceOption option in multipleChoiceQuestion.Options)
                            {
                                MultipleChoiceOptionViewModel optionViewModel = new MultipleChoiceOptionViewModel
                                {
                                    Answer = option.Answer,
                                    Description = option.Description
                                };
                                questionView.Options.Add(optionViewModel);
                            }
                            break;


                    }
                    pageViewModel.Questions.Add(questionView);
                }

                viewModel.PagesList.Add(pageViewModel);
            }

            return viewModel;
        }

        #region Profile Questions
        [HttpGet]
        public IActionResult ProfileQuestions(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult NngbQuestions(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult MotivationQuestions(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId
            };
            return View(model);
        }

        #endregion

        #region Questions
        [HttpGet]
        public IActionResult GeoQuestion(int pageId, int questionId, bool firstGeoQuestionInPage)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId,
                FirstGeoQuestionInPage = firstGeoQuestionInPage
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult MultipleChoiceQuestion(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId,
                OptionId = 0
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult MultipleChoiceOption(int pageId, int questionId, int optionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId,
                OptionId = optionId
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult NumberQuestion(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult SliderQuestion(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId
            };
            return View(model);
        }
        #endregion

        [HttpGet]
        public IActionResult PageView(int pageId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult QuestionView(int pageId, int questionId)
        {
            PageQuestionModel model = new PageQuestionModel
            {
                PageId = pageId,
                QuestionId = questionId
            };
            return View(model);
        }
    }
}
