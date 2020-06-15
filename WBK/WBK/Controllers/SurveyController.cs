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
                            switch (question.Attribute)
                            {
                                case "age":
                                    respondant.Age = model.PagesList[i].Questions[j].NumberAnswer;
                                    break;
                            }
                            question.Answers[0] = new NumberAnswer{ NumberValue = model.PagesList[i].Questions[j].NumberAnswer };
                            break;

                        case TypeEnum.SliderVraag:
                            question.Answers[0] = new NumberAnswer{ NumberValue = model.PagesList[i].Questions[j].NumberAnswer };
                            break;

                        case TypeEnum.OpenVraag:
                            switch (question.Attribute)
                            {
                                case "postcode":
                                    respondant.PostCode = model.PagesList[i].Questions[j].TextAnswer;
                                    break;
                                case "sport":
                                     respondant.DoesSport = !string.IsNullOrEmpty(model.PagesList[i].Questions[j].TextAnswer);
                                    break;
                            }
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

                            switch (question.Attribute)
                            {
                                case "gender":
                                    respondant.Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), answer[0].Answer); 
                                    break;
                                case "profile":
                                    respondant.Profile = (ProfileEnum)Enum.Parse(typeof(ProfileEnum), answer[0].Answer);
                                    break;
                                case "motivation":
                                    respondant.Motivator =  answer[0].Answer;
                                    break;
                                case "reasonNot":
                                    respondant.Restrain = answer[0].Answer;
                                    break;
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

                foreach (GeoQuestion question in page.Questions.OfType<GeoQuestion>())
                {
                    QuestionViewModel questionView = new QuestionViewModel
                    {
                        Title = question.Value,
                        Description = question.Description,
                        ImageUrl = question.ImageUrl,
                        Category = question.Category,
                        Type = question.Type,
                        GeoType = question.TypeOfMarker,
                        StartLocationLat = null,
                        StartLocationLong = null,
                        StartZoomLevel = 13
                    };

                    if (question.StartLocation != null)
                    {
                        questionView.StartLocationLat = question.StartLocation.Latitude.ToString().Replace(',', '.');
                        questionView.StartLocationLong = question.StartLocation.Longitude.ToString().Replace(',', '.');
                        questionView.StartZoomLevel = question.StartLocation.ZoomLevel;
                    }

                    pageViewModel.Questions.Add(questionView);
                }

                foreach (OpenQuestion question in page.Questions.OfType<OpenQuestion>())
                {
                    QuestionViewModel questionView = new QuestionViewModel
                    {
                        Title = question.Value,
                        Description = question.Description,
                        ImageUrl = question.ImageUrl,
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
                        ImageUrl = question.ImageUrl,
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
                            Description = option.Description,
                            ImageUrl = option.ImageUrl
                           
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
                        ImageUrl = question.ImageUrl,
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
                        ImageUrl = question.ImageUrl,
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

        [HttpGet]
        public IActionResult SurveyCompleted()
        {
            return View();
        }
    }
}