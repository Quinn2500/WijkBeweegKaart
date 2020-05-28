using System;
using System.Collections.Generic;
using DataModels;
using DAL;

namespace Logic
{
    public class SurveyLogic
    {
        private readonly SurveyDatabaseCalls _dataBaseCalls = new SurveyDatabaseCalls();
        public void InsertSurvey(Survey survey)
        {
            _dataBaseCalls.InsertSurvey(survey);
        }

        public Survey GetSurvey(int surveyId)
        {
            Survey survey = _dataBaseCalls.GetSurvey(surveyId);
            survey.Pages.Sort((x, y) => x.Id.CompareTo(y.Id));
            foreach (Page page in survey.Pages)
            {
                page.Questions.Sort((x, y) => x.Id.CompareTo(y.Id));
            }

            return survey;
        }

        public Survey GetSurvey(string surveyTitle)
        {
            int? id = _dataBaseCalls.GetSurveyId(surveyTitle);
            if (id != null)
            {
                return GetSurvey((int)id);
            }
            else
            {
                return new Survey();
            }
        }

        public List<SurveyOverview> SurveyOverviewDataOfUser(string userEmail)
        {
            return _dataBaseCalls.SurveyOverviewDataOfUser(userEmail);
        }

        public void DeleteSurvey(string email, string title)
        {
            _dataBaseCalls.DeleteSurvey(email, title);
        }

        public void InserSurveyAnswers(Survey surveyWithAnswers)
        {
            _dataBaseCalls.InsertAnswers(surveyWithAnswers);
        }

        public Survey GetSurveyWithAllAnswers(string surveyTitle)
        {
            Survey survey = _dataBaseCalls.GetSurveyWithAllAnswers(surveyTitle);
            survey.Pages.Sort((x, y) => x.Id.CompareTo(y.Id));
            foreach (Page page in survey.Pages)
            {
                page.Questions.Sort((x, y) => x.Id.CompareTo(y.Id));
            }

            return survey;
        }
    }
}
