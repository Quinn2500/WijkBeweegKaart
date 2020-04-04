using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DataModels;
using DataModels.Answers;
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
                        new MySqlParameter("@pMinVal", question.MinValueText),
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

        public void InsertAnswers(Survey surveyWithAnswers)
        {
            int? surveyId = GetSurveyId(surveyWithAnswers.Title);

            foreach (Page page in surveyWithAnswers.Pages)
            {
                int pageId = (int)GetPageId(page.Title, (int) surveyId);

                foreach (Question question in page.Questions)
                {
                    int questionId = (int)GetQuestionId(question.Value, pageId);
                    int respondantId = (int)InsertRespondant(question.Answer.Respondant);
                    int answerId = (int)InsertAnswer(questionId, respondantId);
                    switch (question.Type)
                    {
                        case TypeEnum.GeoVraag:
                            GeoAnswer geoAnswer = question.Answer as GeoAnswer;
                            string queryGeo = "INSERT INTO `geoanswer`(`GeoData`, `AnswerId`) VALUES (@pGeoData, @pAnswerId)";
                            List<MySqlParameter> parametersGeo = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pGeoData", geoAnswer.GeoData),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(queryGeo, parametersGeo);
                            break;
                        case TypeEnum.OpenVraag:
                            TextAnswer openAnswer = question.Answer as TextAnswer;
                            string queryOpen = "INSERT INTO `textanswer`(`AnswerId`, `textAnswer`) VALUES (@pAnswerId, @pTextValue)";
                            List<MySqlParameter> parametersOpen = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pTextValue", openAnswer.TextValue),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(queryOpen, parametersOpen);
                            break;
                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceAnswer answer = question.Answer as MultipleChoiceAnswer;

                            foreach (MultipleChoiceOption option in answer.AnsweredOptions)
                            {
                                int optionid = (int)GetMultipleChoiceOptionId((int)GetMultipleChoiceQuestionId(questionId), option.Value);
                                string queryMultipleChoice = "INSERT INTO `multiplechoiceanswer`(`MultipleChoiceOptionId`, `AnswerId`) VALUES (@pMPOptionId, @pAnswerId)";
                                List<MySqlParameter> parametersMultipleChoice = new List<MySqlParameter>
                                {
                                    new MySqlParameter("@pMPOptionId", optionid),
                                    new MySqlParameter("@pAnswerId", answerId)
                                };
                                _databaseCalls.Command(queryMultipleChoice, parametersMultipleChoice);
                            }
                            break;

                        case TypeEnum.NummerVraag:
                            NumberAnswer numberAnswer = question.Answer as NumberAnswer;

                            string queryNumber = "INSERT INTO `numberanswer`(`AnswerValue`, `AnswerId`) VALUES (@pNumberValue, @pAnswerId)";
                            List<MySqlParameter> parametersNumber = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pNumberValue", numberAnswer.NumberValue),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(queryNumber, parametersNumber);
                            break;

                        case TypeEnum.SliderVraag:
                            NumberAnswer numberAnswerSlider = question.Answer as NumberAnswer;
                            string query = "INSERT INTO `numberanswer`(`AnswerValue`, `AnswerId`) VALUES (@pNumberValue, @pAnswerId)";
                            List<MySqlParameter> parameters = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pNumberValue", numberAnswerSlider.NumberValue),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(query, parameters);
                            break;
                    }

                }

            }
        }

        public Survey GetSurveyWithAnswers()
        {
            return null;
        }

        private int? GetPageId(string title, int id)
        {
            string query = "SELECT `Id` FROM `page` WHERE page.Title = @pTitle AND page.SurveyId = @pSurveyId";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pTitle", title),
                new MySqlParameter("@pSurveyId", id)
            };
            return _databaseCalls.GetOneInt(query, parameters);
        }

        private int? GetQuestionId(string question, int pageId)
        {
            string query = "SELECT `Id` FROM `question` WHERE question.Question = @pQuestion AND question.PageId = @pPageId";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pQuestion", question),
                new MySqlParameter("@pPageId", pageId)
            };
            return _databaseCalls.GetOneInt(query, parameters);
        }

        private int? InsertAnswer(int questionid, int respondantId)
        {
            string query = "INSERT INTO `answer`(`QuestionId`, `RespondantId`) VALUES (@pQuestionId,@pRespondantId)";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pQuestionId", questionid),
                new MySqlParameter("@pRespondantId", respondantId)
            };
            return _databaseCalls.CommandWithLastId(query, parameters);
        }

        private int? GetMultipleChoiceQuestionId(int questionId)
        {
            string query = "SELECT `Id` FROM `multiplechoicequestion` WHERE multiplechoicequestion.QuestionId = @pQuestionId";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pQuestionId", questionId)
            };
            return _databaseCalls.GetOneInt(query, parameters);
        }

        private int? GetMultipleChoiceOptionId(int multipleQuestionId, string value)
        {
            string query = "SELECT `Id` FROM `multiplechoiceoption` WHERE multiplechoiceoption.MultipleChoiceQuestionId = @pQuestionId AND multiplechoiceoption.Value = @pValue";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pQuestionId", multipleQuestionId),
                new MySqlParameter("@pValue", value)
            };
            return _databaseCalls.GetOneInt(query, parameters);
        }

        private int? InsertRespondant(Respondant respondant)
        {
            string query = "INSERT INTO `respondant`(`SessionId`, `DateOfCompletion`) VALUES (@pSessionId, @pDateOfCompletion)";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pSessionId", respondant.SessionId),
                new MySqlParameter("@pDateOfCompletion", respondant.DateTimeOfCreation)
            };
            return _databaseCalls.CommandWithLastId(query, parameters);
        }

        public SurveyAnswers GetAllsSurveyAnswers(string surveyTitle)
        {
            SurveyAnswers result = new SurveyAnswers
            {
                SurveyTitle = surveyTitle
            };

            int surveyId = (int)GetSurveyId(surveyTitle);

            List<MySqlParameter> parametersSurveyId = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", surveyId),
            };

            string queryPage = "SELECT * FROM `page` WHERE page.SurveyId = @pId";

            foreach (DataRow rowPage in _databaseCalls.Select(queryPage, parametersSurveyId).Rows)
            {

                int pageId = Convert.ToInt32(rowPage[0]);

                string queryQuestion = "SELECT question.Id FROM `question` WHERE Question.PageId = @pId";
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
                    int answerId = (int)GetAnswerId(questionId);
                    List<MySqlParameter> answerIdParameter = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pId", answerId),
                    };
                    TypeEnum questionType = (TypeEnum)Convert.ToInt32(rowQuestion[3]);

                    Respondant respondant = GetRespondant((int)GetRespondentId(answerId));

                    switch (questionType)
                    {

                        case TypeEnum.GeoVraag:
                            string queryGeo = "SELECT * FROM `geoquestion` WHERE geoquestion.QuestionId = @pId";
                            DataRow rowGeo = _databaseCalls.Select(queryGeo, questionIdParameter).Rows[0];

                            string queryAnswer = "SELECT `GeoData` FROM `geoanswer` WHERE geoanswer.AnswerId = @pAnswerId";
                            DataRow rowAnswer = _databaseCalls.Select(queryAnswer, answerIdParameter).Rows[0];

                            GeoAnswer answer = new GeoAnswer
                            {
                                GeoData = rowAnswer[0].ToString(),
                                Respondant = respondant

                            };


                            GeoQuestion geoQuestion = new GeoQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                TypeOfMarker = (GeoTypeEnum)Convert.ToInt32(rowGeo[2]),
                                Answer = answer

                            };
                            result.Questions.Add(geoQuestion);
                            break;

                        case TypeEnum.OpenVraag:
                            OpenQuestion openQuestion = new OpenQuestion
                            {
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType
                            };
                            result.Questions.Add(openQuestion);
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
                            result.Questions.Add(multipleChoiceQuestion);
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
                            result.Questions.Add(sliderQuestion);
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
                            result.Questions.Add(numberQuestion);
                            break;
                    }
                }
            }

            return result;
        }

        private int? GetAnswerId(int questionId)
        {
            string query = "SELECT `Id` FROM `answer` WHERE answer.Id = @pId";
            List<MySqlParameter> parameter = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", questionId),
            };
            return _databaseCalls.GetOneInt(query, parameter);
        }

        private int? GetRespondentId(int answerId)
        {
            string query = "SELECT `RespondentId` FROM `answer` WHERE answer.Id = @pId";
            List<MySqlParameter> parameter = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", answerId),
            };
            return _databaseCalls.GetOneInt(query, parameter);
        }

        private Respondant GetRespondant(int id)
        {
            Respondant result = new Respondant();
            string queryRespondant = "SELECT * FROM `respondant` WHERE respondant.Id = @pId";
            List<MySqlParameter> parametersRespondant = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", id),
            };

            DataRow row = _databaseCalls.Select(queryRespondant, parametersRespondant).Rows[0];
            result.SessionId = row[1].ToString();
            result.DateTimeOfCreation = Convert.ToDateTime(row[2]);
            return result;
        }
    }
 }
