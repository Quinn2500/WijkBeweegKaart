using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DataModels.Answers;
using DataModels.Questions;
using Logic;
using Microsoft.AspNetCore.Mvc;
using WBK.Models.Create;

namespace WBK.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyLogic _logic = new SurveyLogic();

        [HttpGet]
        public IActionResult Survey(string name)
        {
              Survey survey = _logic.GetSurvey(name);
              SurveyViewModel viewModel = ConvertToViewModel(survey);
              return View(viewModel);
        }

        [HttpPost]
        public IActionResult Survey(string name, SurveyViewModel model)
        {
            Survey survey = _logic.GetSurvey(name);
            Respondant respondant = new Respondant
            {
                DateTimeOfCreation = DateTime.Now,
                SessionId = "test"

            };
            for (int i = 0; i < survey.Pages.Count; i++)
            {
                model.PagesList[i].Questions.Reverse();
                for (int j = 0; j < survey.Pages[i].Questions.Count; j++)
                {
                    Question question = survey.Pages[i].Questions[j];
                    question.Answers = new List<Answer>
                    {
                        new GeoAnswer()
                    };
                    switch (question.Type)
                    {
                        case TypeEnum.GeoVraag:
                            question.Answers[0] = new GeoAnswer{GeoData = model.PagesList[i].Questions[j].GeoCodeAnswer}; 
                            break;

                        case TypeEnum.NummerVraag:
                            question.Answers[0] = new NumberAnswer{ NumberValue = model.PagesList[i].Questions[j].NumberAnswer };
                            break;

                        case TypeEnum.SliderVraag:
                            question.Answers[0] = new NumberAnswer{ NumberValue = model.PagesList[i].Questions[j].NumberAnswer };
                            break;

                        case TypeEnum.OpenVraag:
                            question.Answers[0] = new TextAnswer{ TextValue = model.PagesList[i].Questions[j].TextAnswer };
                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceQuestion multipleChoiceQuestion = question as MultipleChoiceQuestion;
                            List<MultipleChoiceOption> answer = new List<MultipleChoiceOption>();
                            QuestionViewModel testQuestion = model.PagesList[i].Questions[j - 1];
                            for (int k = 0; k < multipleChoiceQuestion.Options.Count; k++)
                            {

                                if (testQuestion.Options[k].Selected)
                                {
                                    answer.Add(multipleChoiceQuestion.Options[k]);
                                }
                            }

                            question.Answers[0] = new MultipleChoiceAnswer { AnsweredOptions = answer};
                            break;
                    }
                    question.Answers[0].Respondant = respondant;
                }
            }
            _logic.InserSurveyAnswers(survey);
            return RedirectToAction("SurveysCreatedBy","Create");
        }

        [HttpGet]
        public IActionResult AllAnswers(string surveyTitle)
        {
            Survey model = _logic.GetSurveyWithAllAnswers(surveyTitle);
            return View(model);
        }

        public SurveyViewModel ConvertToViewModel(Survey survey)
        {
            SurveyViewModel viewModel = new SurveyViewModel
            {
                Title = survey.Title,
                Description = survey.Description,
                EndDate = survey.EndDate.ToShortDateString(),
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

            return viewModel;
        }
    }
}