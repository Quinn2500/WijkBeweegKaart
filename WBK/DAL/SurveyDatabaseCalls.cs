using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataModels;
using DataModels.Questions;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace DAL
{
    public class SurveyDatabaseCalls
    {
        private readonly DatabaseCalls _databaseCalls = new DatabaseCalls();

        public void InsertSurvey(Survey survey)
        {
            string querySurvey = "INSERT INTO `survey`(`Title`, `Description`, `DateCreation`, `CreatorEmail`, `StartLocation`, `EndDate`) VALUES (@pTitle, @pDesc,@pDateCreation,@pCreator,@pStartLocation,@pEnddate)";
            List<MySqlParameter> parametersSurvey = new List<MySqlParameter>
            {
                new MySqlParameter("@pTitle", survey.Title),
                new MySqlParameter("@pDesc", survey.Description),
                new MySqlParameter("@pDateCreation", survey.DateOfCreation),
                new MySqlParameter("@pCreator", survey.Owner),
                new MySqlParameter("@pStartLocation", JsonConvert.SerializeObject(survey.StartLocation)),
                new MySqlParameter("@pEnddate", survey.EndDate)
            };

            int? surveyId = _databaseCalls.CommandWithLastId(querySurvey, parametersSurvey);

            foreach (Page page in survey.Pages)
            {
                string queryPage = "INSERT INTO `page`(`SurveyId`, `Title`, `Description`) VALUES (@pSurveyId, @pPageTitle, @pPageDesc)";
                List<MySqlParameter> parametersPage = new List<MySqlParameter>
                {
                    new MySqlParameter("@pSurveyId", surveyId),
                    new MySqlParameter("@pPageTitle", page.Title),
                    new MySqlParameter("@pPageDesc", page.Description)
                };

                int? pageId = _databaseCalls.CommandWithLastId(queryPage, parametersPage);

                foreach (GeoQuestion question in page.Questions.OfType<GeoQuestion>())
                {
                    int? geoQuestionId = InsertQuestion(question, pageId); ;

                    string queryGeoQuestion ="INSERT INTO `geoquestion`(`QuestionId`, `TypeOfMarker`) VALUES (@pQuestionGeoId, @pTypeOfMarker)";
                    List<MySqlParameter> parametersGeoQuestion = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pQuestionGeoId", geoQuestionId),
                        new MySqlParameter("@pTypeOfMarker", question.TypeOfMarker)
                    };

                    _databaseCalls.Command(queryGeoQuestion, parametersGeoQuestion);
                }

                foreach (OpenQuestion question in page.Questions.OfType<OpenQuestion>())
                {
                    InsertQuestion(question, pageId);
                }

                foreach (MultipleChoiceQuestion question in page.Questions.OfType<MultipleChoiceQuestion>())
                {
                    int? multipleChoiceQuestionId = InsertQuestion(question, pageId);

                    string queryMCQuestion = "INSERT INTO `multiplechoicequestion`(`QuestionId`, `MultipleAnswers`) VALUES (@pQuestionId, @pMultipleAnswers)";
                    List<MySqlParameter> parametersMCQuestion = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pQuestionId", multipleChoiceQuestionId),
                        new MySqlParameter("@pMultipleAnswers", question.AllowMutlipleAnwsers)
                    };

                    int? optionId = _databaseCalls.CommandWithLastId(queryMCQuestion, parametersMCQuestion);

                    foreach (MultipleChoiceOption option in question.Options)
                    {
                        string queryOption = "INSERT INTO `multiplechoiceoption`(`MultipleChoiceQuestionId`, `Value`, `Description`) VALUES (@pMCQuestionId, @pValue, @pDesc)";
                        List<MySqlParameter> parametersOption= new List<MySqlParameter>
                        {
                            new MySqlParameter("@pMCQuestionId", optionId),
                            new MySqlParameter("@pValue", option.Value),
                            new MySqlParameter("@pDesc", option.Description)
                        };
                        _databaseCalls.Command(queryOption, parametersOption);
                    }
                }

                foreach (SliderQuestion question in page.Questions.OfType<SliderQuestion>())
                {
                    int? sliderQuestionId = InsertQuestion(question, pageId);

                    string querySliderQuestion = "INSERT INTO `sliderquestion`(`QuestionId`, `MaxValueText`, `MinValueText`, `Scale`) VALUES (@pQuestionId, @pMaxVal, @pMinVal, @pScale)";
                    List<MySqlParameter> parametersSliderQuestion = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pQuestionId", sliderQuestionId),
                        new MySqlParameter("@pMaxVal", question.MaxValueText),
                        new MySqlParameter("@pMinVal", question.MaxValueText),
                        new MySqlParameter("@pScale", question.Scale)
                    };

                    _databaseCalls.Command(querySliderQuestion, parametersSliderQuestion);
                }

                foreach (NumberQuestion question in page.Questions.OfType<NumberQuestion>())
                {
                    int? numberQuestionId = InsertQuestion(question,pageId);

                    string queryNumberQuestion =
                        "INSERT INTO `numberquestion`(`QuestionId`, `MaxValue`, `MinValue`) VALUES (@pQuestionId, @pMaxVal,@pMinVal)";
                    List<MySqlParameter> parametersNumberQuestion = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pQuestionId", numberQuestionId),
                        new MySqlParameter("@pMaxVal", question.Maximum),
                        new MySqlParameter("@pMinVal", question.Minimum)
                    };

                    _databaseCalls.Command(queryNumberQuestion, parametersNumberQuestion);
                }


            }

        }

        public int? InsertQuestion(Question question, int? pageId)
        {
            string query ="INSERT INTO `question`(`Question`, `Description`, `Type`, `PageId`, `Category`) VALUES (@pQuestion,@pDesc,@pType,@pPageId,@pCategoryId)";
            List<MySqlParameter> parameters= new List<MySqlParameter>
            {
                new MySqlParameter("@pQuestion", question.Value),
                new MySqlParameter("@pDesc", question.Description),
                new MySqlParameter("@pType", question.Type),
                new MySqlParameter("@pPageId", pageId),
                new MySqlParameter("@pCategoryId", question.Category)
            };

            return _databaseCalls.CommandWithLastId(query, parameters);
        }

        public int? GetSurveyId(string title)
        {
            string query = "SELECT `Id` FROM `survey` WHERE survey.Title = @pTitle";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pTitle", title)
            };
            return _databaseCalls.GetOneInt(query, parameters);
        }

        public Survey GetSurvey(int id)
        {
            Survey result = new Survey();
            string querySurvey = "SELECT * FROM `survey` WHERE survey.Id = @pId";
            List<MySqlParameter> parametersSurveyId = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", id),
            };

            DataRow rowSurvey = _databaseCalls.Select(querySurvey, parametersSurveyId).Rows[0];
            result.Title = rowSurvey[1].ToString();
            result.Description = rowSurvey[2].ToString();
            result.DateOfCreation = Convert.ToDateTime(rowSurvey[3]);
            result.Owner = rowSurvey[4].ToString();
            result.StartLocation = JsonConvert.DeserializeObject<Location>(rowSurvey[5].ToString());
            result.EndDate = Convert.ToDateTime(rowSurvey[6]);
            result.Pages = new List<Page>();

            string queryPage = "SELECT * FROM `page` WHERE page.SurveyId = @pId";

            foreach (DataRow rowPage in _databaseCalls.Select(queryPage, parametersSurveyId).Rows)
            {
                Page page = new Page
                {
                    Title = rowPage[2].ToString(),
                    Description = rowPage[3].ToString(),
                    Questions = new List<Question>()
                    
                };
                int pageId = Convert.ToInt32(rowPage[0]);

                string queryQuestion = "SELECT * FROM `question` WHERE Question.PageId = @pId";
                List<MySqlParameter> parametersQuestion = new List<MySqlParameter>
                {
                    new MySqlParameter("@pId", pageId),
                };

                foreach (DataRow rowQuestion in _databaseCalls.Select(queryQuestion, parametersQuestion).Rows)
                {
                    int questionId = Convert.ToInt32(rowQuestion[0]);
                    List<MySqlParameter> questionIdParameter = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pId", questionId),
                    };
                    TypeEnum questionType = (TypeEnum)Convert.ToInt32(rowQuestion[3]);

                    switch (questionType)
                    {

                        case TypeEnum.GeoVraag:

                            string queryGeo = "SELECT * FROM `geoquestion` WHERE geoquestion.QuestionId = @pId";
                            DataRow rowGeo = _databaseCalls.Select(queryGeo, questionIdParameter).Rows[0];

                            GeoQuestion geoQuestion = new GeoQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                TypeOfMarker = (GeoTypeEnum)Convert.ToInt32(rowGeo[2]),

                            };
                            page.Questions.Add(geoQuestion);
                            break;

                        case TypeEnum.OpenVraag:
                            OpenQuestion openQuestion = new OpenQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType
                            };
                            page.Questions.Add(openQuestion);
                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            string queryMultiplechoice = "SELECT * FROM `multiplechoicequestion` WHERE multiplechoicequestion.QuestionId =  @pId";
                            DataRow rowMultipleChoice = _databaseCalls.Select(queryMultiplechoice, questionIdParameter).Rows[0];
                            int multipleChoiceId = Convert.ToInt32(rowMultipleChoice[0]);
                            MultipleChoiceQuestion multipleChoiceQuestion = new MultipleChoiceQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                AllowMutlipleAnwsers = Convert.ToBoolean(rowMultipleChoice[2]),
                                Options = new List<MultipleChoiceOption>()
                            };

                            string queryOptions = "SELECT * FROM `multiplechoiceoption` WHERE multiplechoiceoption.MultipleChoiceQuestionId = @pId";
                            List<MySqlParameter> parametersOptions = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pId", multipleChoiceId),
                            };

                            foreach (DataRow rowOption in _databaseCalls.Select(queryOptions, parametersOptions).Rows)
                            {
                                MultipleChoiceOption option = new MultipleChoiceOption
                                {
                                    Value = rowOption[2].ToString(),
                                    Description = rowOption[3].ToString(), 

                                };
                                multipleChoiceQuestion.Options.Add(option);
                            }
                            page.Questions.Add(multipleChoiceQuestion);
                            break;

                        case TypeEnum.SliderVraag:
                            string querySlider = "SELECT * FROM `sliderquestion` WHERE sliderquestion.QuestionId =  @pId";
                            DataRow rowSlider = _databaseCalls.Select(querySlider, questionIdParameter).Rows[0];

                            SliderQuestion sliderQuestion = new SliderQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                MaxValueText = rowSlider[2].ToString(),
                                MinValueText = rowSlider[3].ToString(),
                                Scale = Convert.ToInt32(rowSlider[4])

                            };
                            page.Questions.Add(sliderQuestion);
                            break;

                        case TypeEnum.NummerVraag:

                            string queryNumber = "SELECT * FROM `numberquestion` WHERE numberquestion.QuestionId = @pId";
                            DataRow rowNumber = _databaseCalls.Select(queryNumber, questionIdParameter).Rows[0];

                            NumberQuestion numberQuestion = new NumberQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                Maximum = Convert.ToInt32(rowNumber[2]),
                                Minimum = Convert.ToInt32(rowNumber[3]),
                            };
                            page.Questions.Add(numberQuestion);
                            break;
                    }
                }
                result.Pages.Add(page);
            }

            return result;
        }

        public List<SurveyOverview> SurveyOverviewDataOfUser(string userEmail)
        {
            List<SurveyOverview> result = new List<SurveyOverview>();
            string query =
                "SELECT `Title`, `DateCreation`, `CreatorEmail`, `EndDate` FROM `survey` WHERE survey.CreatorEmail = @pId";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", userEmail),
            };

            foreach (DataRow row in _databaseCalls.Select(query, parameters).Rows)
            {
                SurveyOverview overview = new SurveyOverview
                {
                    Title = row[0].ToString(),
                    CreationDate = Convert.ToDateTime(row[1]),
                    CreatorEmail = row[2].ToString(),
                    EndDate = Convert.ToDateTime(row[3])

                };
                result.Add(overview);

            }

            return result;
        }

        public void DeleteSurvey(string userEmail, string title)
        {
            string deleteSurveyQuery = "DELETE survey, page, question " +
                                       "FROM survey, page, question " +
                                       "WHERE page.SurveyId = survey.Id  AND page.Id = question.PageId AND survey.Title = @pTitle AND survey.CreatorEmail = @pOwner";
            List<MySqlParameter> parametersSurvey = new List<MySqlParameter>
            {
                new MySqlParameter("@pTitle", title),
                new MySqlParameter("@pOwner", userEmail)
            };
            _databaseCalls.Command(deleteSurveyQuery, parametersSurvey);
        }
    }
 }
