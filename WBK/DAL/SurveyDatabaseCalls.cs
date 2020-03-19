using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModels;
using DataModels.Questions;
using MySql.Data.MySqlClient;

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
                new MySqlParameter("@pStartLocation", survey.StartLocation),
                new MySqlParameter("@pEnddate", survey.EndDate)
            };

            int? surveyId = _databaseCalls.CommandWithLastId(querySurvey, parametersSurvey);

            foreach (Page page in survey.Pages)
            {
                string queryPage = "INSERT INTO `page`(`SurveyId`, `Title`, `Description`) VALUES (@pSurveyId,@pPageTitle,@pPageDesc)";
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

                    string queryGeoQuestion ="INSERT INTO `geoquestion`(`QuestionId`, `TypeOfMarker`) VALUES (@pQuestionGeoId,@pTypeOfMarker)";
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

                    string queryMCQuestion = "INSERT INTO `multiplechoicequestion`(`QuestionId`, `MultipleAnswers`) VALUES (@pQuestionId,@pMultipleAnswers)";
                    List<MySqlParameter> parametersMCQuestion = new List<MySqlParameter>
                    {
                        new MySqlParameter("@pQuestionId", multipleChoiceQuestionId),
                        new MySqlParameter("@pMultipleAnswers", question.AllowMutlipleAnwsers)
                    };

                    int? optionId = _databaseCalls.CommandWithLastId(queryMCQuestion, parametersMCQuestion);

                    foreach (MultipleChoiceOption option in question.Options)
                    {
                        string queryOption = "INSERT INTO `multiplechoiceoption`(`MultipleChoiceQuestionId`, `Value`, `Description`) VALUES (@pMCQuestionId,@pValue,@pDesc)";
                        List<MySqlParameter> parametersOption= new List<MySqlParameter>
                        {
                            new MySqlParameter("@pMCQuestionId", optionId),
                            new MySqlParameter("@pValue", option.Value),
                            new MySqlParameter("@pDesc", option.Description)
                        };
                    }
                }

                foreach (SliderQuestion question in page.Questions.OfType<SliderQuestion>())
                {
                    int? sliderQuestionId = InsertQuestion(question, pageId);

                    string querySliderQuestion =
                        "INSERT INTO `sliderquestion`(`QuestionId`, `MaxValueText`, `MinValueText`, `Scale`) VALUES (@pQuestionId,@pMaxVal,@pMinVal],@pScale)";
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
            string query ="INSERT INTO `question`(`Question`, `Description`, `TypeId`, `PageId`, `CategoryId`) VALUES (@pQuestion,@pDesc,@pType,@pPageId,@pCategoryId)";
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


    }
 }
