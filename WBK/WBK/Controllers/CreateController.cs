﻿using System;
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
                        Description = page.Description,
                        Title = page.Title,
                        Questions = new List<QuestionViewModel>()
                    };

                    foreach (GeoQuestion question in page.Questions.OfType<GeoQuestion>())
                    {
                        QuestionViewModel questionView = new QuestionViewModel
                        {
                            Title = question.Value,
                            Description = question.Description,
                            Category = question.Category,
                            Type = question.Type,
                            GeoType = question.TypeOfMarker
                        };
                        pageViewModel.Questions.Add(questionView);
                    }

                    foreach (OpenQuestion question in page.Questions.OfType<OpenQuestion>())
                    {
                        QuestionViewModel questionView = new QuestionViewModel
                        {
                            Title = question.Value,
                            Description = question.Description,
                            Category = question.Category,
                            Type = question.Type
                        };
                        pageViewModel.Questions.Add(questionView);
                    }

                    foreach (MultipleChoiceQuestion question in page.Questions.OfType<MultipleChoiceQuestion>())
                    {
                        QuestionViewModel questionView = new QuestionViewModel
                        {
                            Title = question.Value,
                            Description = question.Description,
                            Category = question.Category,
                            Type = question.Type,
                            MaximumNumberOfAnswers = question.MaximumNumberOfAnswers,
                            Options = new List<MultipleChoiceOptionViewModel>()
                        };
                        foreach (MultipleChoiceOption option in question.Options)
                        {
                            MultipleChoiceOptionViewModel optionViewModel = new MultipleChoiceOptionViewModel
                            {
                                Answer = option.Answer,
                                Description = option.Description
                            };
                            questionView.Options.Add(optionViewModel);
                        }
                        pageViewModel.Questions.Add(questionView);
                    }

                    foreach (SliderQuestion question in page.Questions.OfType<SliderQuestion>())
                    {
                        QuestionViewModel questionView = new QuestionViewModel
                        {
                            Title = question.Value,
                            Description = question.Description,
                            Category = question.Category,
                            Type = question.Type,
                            SliderScaleVal = question.Scale,
                            SliderMaxText = question.MaxValueText,
                            SliderMinText = question.MinValueText
                        };
                        pageViewModel.Questions.Add(questionView);
                    }

                    foreach (NumberQuestion question in page.Questions.OfType<NumberQuestion>())
                    {
                        QuestionViewModel questionView = new QuestionViewModel
                        {
                            Title = question.Value,
                            Description = question.Description,
                            Category = question.Category,
                            Type = question.Type,
                            MinValue = question.Minimum,
                            MaxValue = question.Maximum
                        };
                        pageViewModel.Questions.Add(questionView);
                    }

                    viewModel.PagesList.Add(pageViewModel);
                }
                return View(viewModel);
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
            _logic.InsertSurvey(surveyModel);

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
