using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DataModels.Questions;
using Logic;
using Microsoft.AspNetCore.Mvc;
using WBK.Models.Create;

namespace WBK.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyLogic _logic = new SurveyLogic();
        public IActionResult Survey()
        {
              Survey survey = _logic.GetSurvey("testTest");

                SurveyViewModel viewModel = new SurveyViewModel
                {
                    Title = survey.Title,
                    Description = survey.Description,
                    EndDate = survey.EndDate,
                    StartLocationLat = survey.StartLocation.Latitude.ToString(),
                    StartLocationLong = survey.StartLocation.Longitude.ToString(),
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
                            AllowMultipleAnswers = question.AllowMutlipleAnwsers,
                            Options = new List<MultipleChoiceOptionViewModel>()
                        };
                        foreach (MultipleChoiceOption option in question.Options)
                        {
                            MultipleChoiceOptionViewModel optionViewModel = new MultipleChoiceOptionViewModel
                            {
                                Answer = option.Value,
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
    }
}