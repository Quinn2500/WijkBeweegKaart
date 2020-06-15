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
            string querySurvey = "INSERT INTO `survey`(`Title`, `Description`, `DateCreation`, `CreatorEmail`,`EndDate`, `ImageUrl`) VALUES (@pTitle, @pDesc,@pDateCreation,@pCreator,@pEnddate,@pImageUrl)";
            List<MySqlParameter> parametersSurvey = new List<MySqlParameter>
            {
                new MySqlParameter("@pTitle", survey.Title),
                new MySqlParameter("@pDesc", survey.Description),
                new MySqlParameter("@pDateCreation", survey.DateOfCreation),
                new MySqlParameter("@pCreator", survey.Owner),
                new MySqlParameter("@pEnddate", survey.EndDate),
                new MySqlParameter("@pImageUrl", survey.ImageUrl)
            };

            int? surveyId = _databaseCalls.CommandWithLastId(querySurvey, parametersSurvey);

            foreach (Page page in survey.Pages)
            {
                string queryPage = "INSERT INTO `page`(`SurveyId`, `Title`, `Description`, `ImageUrl`) VALUES (@pSurveyId, @pPageTitle, @pPageDesc,@pImageUrl)";
                List<MySqlParameter> parametersPage = new List<MySqlParameter>
                {
                    new MySqlParameter("@pSurveyId", surveyId),
                    new MySqlParameter("@pPageTitle", page.Title),
                    new MySqlParameter("@pPageDesc", page.Description),
                    new MySqlParameter("@pImageUrl", survey.ImageUrl)
                };

                int? pageId = _databaseCalls.CommandWithLastId(queryPage, parametersPage);

                foreach (Question question in page.Questions)
                {
                    int? questionId = InsertQuestion(question, pageId);
                    switch (question.Type)
                    {
                        case TypeEnum.GeoVraag:
                            GeoQuestion geo = question as GeoQuestion;

                            string queryGeoQuestion = "INSERT INTO `geoquestion`(`QuestionId`, `TypeOfMarker`) VALUES (@pQuestionGeoId, @pTypeOfMarker)";
                            List<MySqlParameter> parametersGeoQuestion = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pQuestionGeoId", questionId),
                                new MySqlParameter("@pTypeOfMarker", geo.TypeOfMarker)
                            };

                            if (geo.StartLocation != null)
                            {
                                parametersGeoQuestion.Add(new MySqlParameter("@pStartLocation", JsonConvert.SerializeObject(geo.StartLocation)));
                                queryGeoQuestion = "INSERT INTO `geoquestion`(`QuestionId`, `TypeOfMarker`, `StartLocation`) VALUES (@pQuestionGeoId, @pTypeOfMarker, @pStartLocation)";
                            }

                            _databaseCalls.Command(queryGeoQuestion, parametersGeoQuestion);
                            break;

                        case TypeEnum.OpenVraag:
                            InsertQuestion(question, pageId);
                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceQuestion multipleChoiceQuestion = question as MultipleChoiceQuestion;

                            string queryMCQuestion = "INSERT INTO `multiplechoicequestion`(`QuestionId`, `MultipleAnswers`) VALUES (@pQuestionId, @pMultipleAnswers)";
                            List<MySqlParameter> parametersMCQuestion = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pQuestionId", questionId),
                                new MySqlParameter("@pMultipleAnswers", multipleChoiceQuestion.MaximumNumberOfAnswers)
                            };

                            int? optionId = _databaseCalls.CommandWithLastId(queryMCQuestion, parametersMCQuestion);

                            foreach (MultipleChoiceOption option in multipleChoiceQuestion.Options)
                            {
                                string queryOption = "INSERT INTO `multiplechoiceoption`(`MultipleChoiceQuestionId`, `Value`, `Description`, `ImageUrl`) VALUES (@pMCQuestionId, @pValue, @pDesc, @pImageUrl)";
                                List<MySqlParameter> parametersOption = new List<MySqlParameter>
                                {
                                    new MySqlParameter("@pMCQuestionId", optionId),
                                    new MySqlParameter("@pValue", option.Answer),
                                    new MySqlParameter("@pDesc", option.Description),
                                    new MySqlParameter("@pImageUrl", option.ImageUrl)
                                };
                                _databaseCalls.Command(queryOption, parametersOption);
                            }
                            break;

                        case TypeEnum.NummerVraag:
                            NumberQuestion numberQuestion = question as NumberQuestion;
                            string queryNumberQuestion =
                                "INSERT INTO `numberquestion`(`QuestionId`, `MaxValue`, `MinValue`) VALUES (@pQuestionId, @pMaxVal,@pMinVal)";
                            List<MySqlParameter> parametersNumberQuestion = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pQuestionId", questionId),
                                new MySqlParameter("@pMaxVal", numberQuestion.Maximum),
                                new MySqlParameter("@pMinVal", numberQuestion.Minimum)
                            };

                            _databaseCalls.Command(queryNumberQuestion, parametersNumberQuestion);
                            break;

                        case TypeEnum.SliderVraag:
                            SliderQuestion sliderQuestion = question as SliderQuestion;
                            string querySliderQuestion = "INSERT INTO `sliderquestion`(`QuestionId`, `MaxValueText`, `MinValueText`, `Scale`) VALUES (@pQuestionId, @pMaxVal, @pMinVal, @pScale)";
                            List<MySqlParameter> parametersSliderQuestion = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pQuestionId", questionId),
                                new MySqlParameter("@pMaxVal", sliderQuestion.MaxValueText),
                                new MySqlParameter("@pMinVal", sliderQuestion.MinValueText),
                                new MySqlParameter("@pScale", sliderQuestion.Scale)
                            };

                            _databaseCalls.Command(querySliderQuestion, parametersSliderQuestion);
                            break;
                    }
                }

            }

        }

        public int? InsertQuestion(Question question, int? pageId)
        {
            string query = "INSERT INTO `question`(`Question`, `Description`, `Type`, `PageId`, `Category`, `ImageUrl` , `Attribute`) VALUES (@pQuestion,@pDesc,@pType,@pPageId,@pCategoryId,@pImageUrl,@pAttribute)";
            List<MySqlParameter> parameters= new List<MySqlParameter>
            {
                new MySqlParameter("@pQuestion", question.Value),
                new MySqlParameter("@pDesc", question.Description),
                new MySqlParameter("@pType", question.Type),
                new MySqlParameter("@pPageId", pageId),
                new MySqlParameter("@pCategoryId", question.Category),
                new MySqlParameter("@pImageUrl", question.ImageUrl),
                new MySqlParameter("@pAttribute", question.Attribute)
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
            result.EndDate = Convert.ToDateTime(rowSurvey[5]);
            result.ImageUrl = rowSurvey[6].ToString();
            result.Pages = new List<Page>();

            string queryPage = "SELECT * FROM `page` WHERE page.SurveyId = @pId";

            foreach (DataRow rowPage in _databaseCalls.Select(queryPage, parametersSurveyId).Rows)
            {
                Page page = new Page
                {
                    Id = Convert.ToInt32(rowPage[0]),
                    Title = rowPage[2].ToString(),
                    Description = rowPage[3].ToString(),
                    Questions = new List<Question>(),
                    ImageUrl = rowPage[4].ToString()

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
                                Id = Convert.ToInt32(rowQuestion[0]),
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                TypeOfMarker = (GeoTypeEnum)Convert.ToInt32(rowGeo[2]),
                                StartLocation = null,
                                ImageUrl = rowQuestion[6].ToString(),
                                Attribute = rowQuestion[7].ToString()

                            };

                            if (rowGeo[3] != null)
                            {
                                geoQuestion.StartLocation =
                                    JsonConvert.DeserializeObject<Location>(rowGeo[3].ToString());
                            }

                            page.Questions.Add(geoQuestion);
                            break;

                        case TypeEnum.OpenVraag:
                            OpenQuestion openQuestion = new OpenQuestion
                            {
                                Id = Convert.ToInt32(rowQuestion[0]),
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                ImageUrl = rowQuestion[6].ToString(),
                                Attribute = rowQuestion[7].ToString()
                            };
                            page.Questions.Add(openQuestion);
                            break;

                        case TypeEnum.MeerkeuzeVraag:
                            string queryMultiplechoice = "SELECT * FROM `multiplechoicequestion` WHERE multiplechoicequestion.QuestionId =  @pId";
                            DataRow rowMultipleChoice = _databaseCalls.Select(queryMultiplechoice, questionIdParameter).Rows[0];
                            int multipleChoiceId = Convert.ToInt32(rowMultipleChoice[0]);
                            MultipleChoiceQuestion multipleChoiceQuestion = new MultipleChoiceQuestion
                            {
                                Id = Convert.ToInt32(rowQuestion[0]),
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                MaximumNumberOfAnswers = Convert.ToInt32(rowMultipleChoice[2]),
                                Options = new List<MultipleChoiceOption>(),
                                ImageUrl = rowQuestion[6].ToString(),
                                Attribute = rowQuestion[7].ToString()
                            };

                            string queryOptions = "SELECT * FROM `multiplechoiceoption` WHERE multiplechoiceoption.MultipleChoiceQuestionId = @pId";
                            List<MySqlParameter> parametersOptions = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pId", multipleChoiceId),
                            };

                            foreach (DataRow rowOption in _databaseCalls.Select(queryOptions, parametersOptions).Rows)
                            {
                                MultipleChoiceOption option = new MultipleChoiceOption(rowOption[2].ToString(),
                                    rowOption[3].ToString(), rowOption[4].ToString());
                                multipleChoiceQuestion.Options.Add(option);
                            }
                            page.Questions.Add(multipleChoiceQuestion);
                            break;

                        case TypeEnum.SliderVraag:
                            string querySlider = "SELECT * FROM `sliderquestion` WHERE sliderquestion.QuestionId =  @pId";
                            DataRow rowSlider = _databaseCalls.Select(querySlider, questionIdParameter).Rows[0];

                            SliderQuestion sliderQuestion = new SliderQuestion
                            {
                                Id = Convert.ToInt32(rowQuestion[0]),
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                MaxValueText = rowSlider[2].ToString(),
                                MinValueText = rowSlider[3].ToString(),
                                Scale = Convert.ToInt32(rowSlider[4]),
                                ImageUrl = rowQuestion[6].ToString(),
                                Attribute = rowQuestion[7].ToString()

                            };
                            page.Questions.Add(sliderQuestion);
                            break;

                        case TypeEnum.NummerVraag:

                            string queryNumber = "SELECT * FROM `numberquestion` WHERE numberquestion.QuestionId = @pId";
                            DataRow rowNumber = _databaseCalls.Select(queryNumber, questionIdParameter).Rows[0];

                            NumberQuestion numberQuestion = new NumberQuestion
                            {
                                Id = Convert.ToInt32(rowQuestion[0]),
                                Value = rowQuestion[1].ToString(),
                                Description = rowQuestion[2].ToString(),
                                Category = (CategoryEnum)Convert.ToInt32(rowQuestion[5]),
                                Type = questionType,
                                Maximum = Convert.ToInt32(rowNumber[2]),
                                Minimum = Convert.ToInt32(rowNumber[3]),
                                ImageUrl = rowQuestion[6].ToString(),
                                Attribute = rowQuestion[7].ToString()
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
            int respondantId = -1;
            foreach (Page page in surveyWithAnswers.Pages)
            {
                int pageId = (int)GetPageId(page.Title, (int) surveyId);

                foreach (Question question in page.Questions)
                {
                    int questionId = (int)GetQuestionId(question.Value, pageId);

                    if (GetRespondentId(question.Answers[0].Respondant.SessionId) == null)
                    {
                        respondantId = (int)InsertRespondant(question.Answers[0].Respondant);
                    }
                    else
                    {
                        respondantId = (int)GetRespondentId(question.Answers[0].Respondant.SessionId);
                    }
                    int answerId = (int)InsertAnswer(questionId, respondantId);
                    switch (question.Type)
                    {
                        case TypeEnum.GeoVraag:
                            GeoAnswer geoAnswer = question.Answers[0] as GeoAnswer;
                            string queryGeo = "INSERT INTO `geoanswer`(`GeoData`, `AnswerId`) VALUES (@pGeoData, @pAnswerId)";
                            List<MySqlParameter> parametersGeo = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pGeoData", geoAnswer.GeoData),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(queryGeo, parametersGeo);
                            break;
                        case TypeEnum.OpenVraag:
                            TextAnswer openAnswer = question.Answers[0] as TextAnswer;
                            string queryOpen = "INSERT INTO `textanswer`(`AnswerId`, `textAnswer`) VALUES (@pAnswerId, @pTextValue)";
                            List<MySqlParameter> parametersOpen = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pTextValue", openAnswer.TextValue),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(queryOpen, parametersOpen);
                            break;
                        case TypeEnum.MeerkeuzeVraag:
                            MultipleChoiceAnswer answer = question.Answers[0] as MultipleChoiceAnswer;

                            foreach (MultipleChoiceOption option in answer.AnsweredOptions)
                            {
                                int optionid = (int)GetMultipleChoiceOptionId((int)GetMultipleChoiceQuestionId(questionId), option);
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
                            NumberAnswer numberAnswer = question.Answers[0] as NumberAnswer;

                            string queryNumber = "INSERT INTO `numberanswer`(`AnswerValue`, `AnswerId`) VALUES (@pNumberValue, @pAnswerId)";
                            List<MySqlParameter> parametersNumber = new List<MySqlParameter>
                            {
                                new MySqlParameter("@pNumberValue", numberAnswer.NumberValue),
                                new MySqlParameter("@pAnswerId", answerId)
                            };
                            _databaseCalls.Command(queryNumber, parametersNumber);
                            break;

                        case TypeEnum.SliderVraag:
                            NumberAnswer numberAnswerSlider = question.Answers[0] as NumberAnswer;
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

        public int? GetRespondentId(string respondantSessionId)
        {
            string query = "SELECT `Id` FROM `respondant` WHERE respondant.SessionId = @pSessionId";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pSessionId", respondantSessionId)
            };
            return _databaseCalls.GetOneInt(query, parameters);
        }

        private int? GetPageId(string title, int surveyId)
        {
            string query = "SELECT `Id` FROM `page` WHERE page.Title = @pTitle AND page.SurveyId = @pSurveyId";
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
                new MySqlParameter("@pTitle", title),
                new MySqlParameter("@pSurveyId", surveyId)
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

        private int? GetMultipleChoiceOptionId(int multipleQuestionId, MultipleChoiceOption option)
        {
            string query = "";
            List<MySqlParameter> parameters = new List<MySqlParameter>();

            if (string.IsNullOrEmpty(option.Answer))
            {
                query = "SELECT `Id` FROM `multiplechoiceoption` WHERE multiplechoiceoption.MultipleChoiceQuestionId = @pQuestionId AND multiplechoiceoption.ImageURL = @pValue";
                parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@pQuestionId", multipleQuestionId),
                    new MySqlParameter("@pValue", option.ImageUrl)
                };
            }
            else
            {
                query = "SELECT `Id` FROM `multiplechoiceoption` WHERE multiplechoiceoption.MultipleChoiceQuestionId = @pQuestionId AND multiplechoiceoption.Value = @pValue";
                parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("@pQuestionId", multipleQuestionId),
                    new MySqlParameter("@pValue", option.Answer)
                };
            }

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

        public Survey GetSurveyWithAllAnswers(string surveyTitle)
        {
            int surveyId = (int)GetSurveyId(surveyTitle);
            Survey result = GetSurvey(surveyId);

            foreach (Page page in result.Pages)
            {
                int pageId = (int) GetPageId(page.Title, surveyId);
                foreach (Question question in page.Questions)
                {
                    question.Answers = new List<Answer>();

                    int questionId = (int) GetQuestionId(question.Value, pageId);

                    string queryAnswers = "SELECT * FROM `answer` WHERE answer.QuestionId =  @pQuestionId";
                    List<MySqlParameter> parametersAnswers = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pQuestionId", questionId),
                    };

                    foreach (DataRow rowQuestion in _databaseCalls.Select(queryAnswers, parametersAnswers).Rows)
                    {
                        int answerId = Convert.ToInt32(rowQuestion[0].ToString());
                        List<MySqlParameter> answerIdParameter = new List<MySqlParameter>
                        {
                            new MySqlParameter("@pAnswerId", answerId),
                        };

                        Respondant respondant = GetRespondant(Convert.ToInt32(rowQuestion[2]));


                        switch (question.Type)
                        {

                            case TypeEnum.GeoVraag:
                                string queryAnswer = "SELECT `GeoData` FROM `geoanswer` WHERE geoanswer.AnswerId = @pAnswerId";
                                DataRow rowAnswer = _databaseCalls.Select(queryAnswer, answerIdParameter).Rows[0];

                                GeoAnswer answer = new GeoAnswer
                                {
                                    GeoData = rowAnswer[0].ToString(),
                                    Respondant = respondant,
                                    Id = answerId

                                };

                                question.Answers.Add(answer);
                                break;

                            case TypeEnum.OpenVraag:

                                string queryAnswerOpen = "SELECT `textAnswer` FROM `textanswer` WHERE textanswer.AnswerId = @pAnswerId";
                                DataRowCollection rows = _databaseCalls.Select(queryAnswerOpen, answerIdParameter).Rows;

                                TextAnswer answerOpen = new TextAnswer
                                {
                                    TextValue = "",
                                    Respondant = respondant,
                                    Id = answerId

                                };

                                if (rows.Count > 0)
                                {
                                    DataRow rowAnswerOpen = rows[0];

                                    answerOpen.TextValue = rowAnswerOpen[0].ToString();
                                }

                                question.Answers.Add(answerOpen);
                                break;

                            case TypeEnum.MeerkeuzeVraag:

                                MultipleChoiceAnswer answerMultipleChoice = new MultipleChoiceAnswer
                                {
                                    Respondant = respondant,
                                    AnsweredOptions = new List<MultipleChoiceOption>(),
                                    Id = answerId


                                };
                                string queryAnswerMultipleChoice = "SELECT `MultipleChoiceOptionId` FROM `multiplechoiceanswer` WHERE multiplechoiceanswer.AnswerId = @pAnswerId";
                                foreach (DataRow answerRow in _databaseCalls.Select(queryAnswerMultipleChoice, answerIdParameter).Rows)
                                {
                                    string queryAnswerMultipleChoiceOption = "SELECT `Value`, `Description`, `ImageURL` FROM `multiplechoiceoption` WHERE multiplechoiceoption.Id = @pId";
                                    List<MySqlParameter> parameterAnswerMultipleChoiceOption = new List<MySqlParameter>
                                        {
                                            new MySqlParameter("@pId", Convert.ToInt32(answerRow[0])),
                                        };
                                    DataRow rowMultipleChoiceOptionAnswer = _databaseCalls.Select(queryAnswerMultipleChoiceOption, parameterAnswerMultipleChoiceOption).Rows[0];
                                    MultipleChoiceOption option = new MultipleChoiceOption(rowMultipleChoiceOptionAnswer[0].ToString(), rowMultipleChoiceOptionAnswer[1].ToString(), rowMultipleChoiceOptionAnswer[2].ToString());
                                    answerMultipleChoice.AnsweredOptions.Add(option);
                                }
                                question.Answers.Add(answerMultipleChoice);
                                break;

                            case TypeEnum.SliderVraag:

                                string queryAnswerSlider = "SELECT `AnswerValue` FROM `numberanswer` WHERE numberanswer.AnswerId = @pAnswerId";
                                DataRow rowAnswerSlider = _databaseCalls.Select(queryAnswerSlider, answerIdParameter).Rows[0];

                                NumberAnswer answerSlider = new NumberAnswer
                                {
                                    NumberValue = Convert.ToInt32(rowAnswerSlider[0]),
                                    Respondant = respondant,
                                    Id = answerId

                                };
                                question.Answers.Add(answerSlider);
                                break;

                            case TypeEnum.NummerVraag:

                                string queryAnswerNumber = "SELECT `AnswerValue` FROM `numberanswer` WHERE numberanswer.AnswerId = @pAnswerId";
                                DataRow rowAnswerNumber = _databaseCalls.Select(queryAnswerNumber, answerIdParameter).Rows[0];

                                NumberAnswer answerNumber = new NumberAnswer
                                {
                                    NumberValue = Convert.ToInt32(rowAnswerNumber[0]),
                                    Respondant = respondant,
                                    Id = answerId

                                };
                                question.Answers.Add(answerNumber);
                                break;
                        }
                    }

                    
                }
            }

            return result;
        }


        private int? GetAnswerId(int questionId)
        {
            string query = "SELECT `Id` FROM `answer` WHERE answer.QuestionId = @pId";
            List<MySqlParameter> parameter = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", questionId),
            };
            return _databaseCalls.GetOneInt(query, parameter);
        }

        private int? GetRespondentId(int answerId)
        {
            string query = "SELECT `RespondantId` FROM `answer` WHERE answer.id = @pId";
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

        public List<int> GetAllRespondentIdsFromSurveyId(int surveyId)
        {
            List<int> allRespondantIds = new List<int>();
            string query = "SELECT RespondantId FROM `respondanttosurvey` WHERE respondanttosurvey.SurveyId = @pId";
            List<MySqlParameter> parameter = new List<MySqlParameter>
            {
                new MySqlParameter("@pId", surveyId),
            };

            foreach (DataRow row in _databaseCalls.Select(query, parameter).Rows)
            {
                allRespondantIds.Add(Convert.ToInt32(row[0].ToString()));
            }

            return allRespondantIds;
        }
    }
 }
