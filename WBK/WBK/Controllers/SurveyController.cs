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
            if (survey.EndDate <= DateTime.Today)
            {
                return RedirectToAction("SurveyEnded", "Survey");
            }
            SurveyViewModel viewModel = ConvertToViewModel(survey);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Survey(SurveyViewModel model)
        {
            Survey survey = _logic.GetSurvey(model.Title);
            Guid guid = Guid.NewGuid();
            Respondant respondant = new Respondant
            {
                DateTimeOfCreation = DateTime.Now,
                SessionId = guid.ToString()

            };

            for (int i = 0; i < survey.Pages.Count; i++)
            {
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
                            QuestionViewModel testQuestion = model.PagesList[i].Questions[j];
                            for (int k = 0; k < testQuestion.Options.Count; k++)
                            {

                                if (testQuestion.Options[k].Selected)
                                {
                                    answer.Add(multipleChoiceQuestion.Options[k]);
                                }
                            }

                            question.Answers[0] = new MultipleChoiceAnswer { AnsweredOptions = answer };
                            break;


                    }
                    question.Answers[0].Respondant = respondant;
                }
            }
            _logic.InserSurveyAnswers(survey);
            return RedirectToAction("SurveyCompleted", "Survey");
        }
 

        public SurveyViewModel ConvertToViewModel(Survey survey)
        {
            SurveyViewModel viewModel = new SurveyViewModel
            {
                Title = survey.Title,
                Description = survey.Description,
                ImageUrl = survey.ImageUrl,
                EndDate = survey.EndDate.ToShortDateString(),
                PagesList = new List<PageViewModel>()
            };

            foreach (Page page in survey.Pages)
            {
                PageViewModel pageViewModel = new PageViewModel
                {
                    Description = page.Description,
                    Title = page.Title,
                    ImageUrl = page.ImageUrl,
                    Questions = new List<QuestionViewModel>()
                };

                foreach (Question question in page.Questions)
                {
                    switch (question.Type)
                    {

                        case TypeEnum.GeoVraag:
                            GeoQuestion geoQuestion = question as GeoQuestion;

                            QuestionViewModel questionView = new QuestionViewModel
                            {
                                Title = geoQuestion.Value,
                                Description = geoQuestion.Description,
                                ImageUrl = geoQuestion.ImageUrl,
                                Category = geoQuestion.Category,
                                Type = geoQuestion.Type,
                                IsRequierd = geoQuestion.IsRequired,
                                GeoType = geoQuestion.TypeOfMarker,
                                StartLocationLat = null,
                                StartLocationLong = null,
                                StartZoomLevel = 13
                            };

                            if (geoQuestion.StartLocation != null)
                            {
                                questionView.StartLocationLat = geoQuestion.StartLocation.Latitude.ToString().Replace(',', '.');
                                questionView.StartLocationLong = geoQuestion.StartLocation.Longitude.ToString().Replace(',', '.');
                                questionView.StartZoomLevel = geoQuestion.StartLocation.ZoomLevel;
                            }

                            pageViewModel.Questions.Add(questionView);

                            break;

                        case TypeEnum.OpenVraag:
                            OpenQuestion openQuestion = question as OpenQuestion;

                            QuestionViewModel openQuestionView = new QuestionViewModel
                            {
                                Title = openQuestion.Value,
                                Description = openQuestion.Description,
                                IsRequierd = openQuestion.IsRequired,
                                ImageUrl = openQuestion.ImageUrl,
                                Category = openQuestion.Category,
                                Type = openQuestion.Type
                            };
                            pageViewModel.Questions.Add(openQuestionView);

                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceQuestion multipleChoiceQuestion = question as MultipleChoiceQuestion;

                            QuestionViewModel mulitpleChoiQuestionViewModel = new QuestionViewModel
                            {
                                Title = multipleChoiceQuestion.Value,
                                Description = multipleChoiceQuestion.Description,
                                IsRequierd = multipleChoiceQuestion.IsRequired,
                                ImageUrl = multipleChoiceQuestion.ImageUrl,
                                Category = multipleChoiceQuestion.Category,
                                Type = multipleChoiceQuestion.Type,
                                MaximumNumberOfAnswers = multipleChoiceQuestion.MaximumNumberOfAnswers,
                                Options = new List<MultipleChoiceOptionViewModel>()
                            };
                            foreach (MultipleChoiceOption option in multipleChoiceQuestion.Options)
                            {
                                MultipleChoiceOptionViewModel optionViewModel = new MultipleChoiceOptionViewModel
                                {
                                    Answer = option.Answer,
                                    Description = option.Description,
                                    ImageUrl = option.ImageUrl

                                };
                                mulitpleChoiQuestionViewModel.Options.Add(optionViewModel);
                            }
                            pageViewModel.Questions.Add(mulitpleChoiQuestionViewModel);

                            break;

                        case TypeEnum.SliderVraag:

                            SliderQuestion sliderQuestion = question as SliderQuestion;
                            QuestionViewModel sliderQuestionView = new QuestionViewModel
                            {
                                Title = sliderQuestion.Value,
                                ImageUrl = sliderQuestion.ImageUrl,
                                Description = sliderQuestion.Description,
                                IsRequierd = sliderQuestion.IsRequired,
                                Category = sliderQuestion.Category,
                                Type = sliderQuestion.Type,
                                SliderScaleVal = sliderQuestion.Scale,
                                SliderMaxText = sliderQuestion.MaxValueText,
                                SliderMinText = sliderQuestion.MinValueText
                            };
                            pageViewModel.Questions.Add(sliderQuestionView);
                            break;

                        case TypeEnum.NummerVraag:


                            NumberQuestion numberQuestion = question as NumberQuestion;
                            QuestionViewModel numberQuestionView = new QuestionViewModel
                            {
                                Title = numberQuestion.Value,
                                ImageUrl = numberQuestion.ImageUrl,
                                Description = numberQuestion.Description,
                                IsRequierd = numberQuestion.IsRequired,
                                Category = numberQuestion.Category,
                                Type = numberQuestion.Type,
                                MinValue = numberQuestion.Minimum,
                                MaxValue = numberQuestion.Maximum
                            };
                            pageViewModel.Questions.Add(numberQuestionView);
                            break;
                    }
                }

                viewModel.PagesList.Add(pageViewModel);
            }

            return viewModel;
        }

        [HttpGet]
        public IActionResult SurveyCompleted()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SurveyEnded()
        {
            return View();
        }
    }
}