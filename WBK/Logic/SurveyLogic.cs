using System;
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
    }
}
