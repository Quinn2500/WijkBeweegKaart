using System;
using System.Collections.Generic;
using DataModels;
using DataModels.Answers;
using DataModels.Questions;
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
                Survey survey = GetSurvey((int)id);
                survey.Pages.Sort((x, y) => x.Id.CompareTo(y.Id));
                foreach (Page page in survey.Pages)
                {
                    page.Questions.Sort((x, y) => x.QuestionNumber.CompareTo(y.QuestionNumber));
                }

                return survey;
            }

            return new Survey();
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
                page.Questions.Sort((x, y) => x.QuestionNumber.CompareTo(y.QuestionNumber));
                foreach (Question question in page.Questions)
                {
                    
                    foreach (Answer answer in question.Answers)
                    {
                        Respondant respondant = answer.Respondant;
                        string nngbHighIntensity = "";
                        string nngbMediumIntensity = "";
                        bool satifiesHigh = false;
                        bool satifiesMedium = false;
                        foreach (Answer respondantAnswer in survey.Pages[0].Questions[0].Answers)
                        {
                            if (respondant.SessionId == respondantAnswer.Respondant.SessionId)
                            {
                                respondant = respondantAnswer.Respondant;
                            }
                        }

                        switch (question.Attribute)
                        {
                            case "age":
                                var ageAnswer = answer as NumberAnswer;
                                respondant.Age = ageAnswer.NumberValue;
                                break;
                            case "postcode":
                                var postcodeAnswer = answer as TextAnswer;
                                respondant.PostCode = postcodeAnswer.TextValue;
                                break;
                            case "sport":
                                var sportAnswer = answer as TextAnswer;
                                respondant.DoesSport = !string.IsNullOrEmpty(sportAnswer.TextValue);
                                break;
                            case "gender":
                                var genderAnswer = answer as MultipleChoiceAnswer;
                                respondant.Gender = genderAnswer.AnsweredOptions.Count == 1
                                    ? (GenderEnum?)(GenderEnum)Enum.Parse(typeof(GenderEnum), genderAnswer.AnsweredOptions[0].Answer)
                                    : null;
                                break;
                            case "profile":
                                var profileAnswer = answer as MultipleChoiceAnswer;
                                respondant.Profile = profileAnswer.AnsweredOptions.Count == 1
                                    ? (ProfileEnum?)(ProfileEnum)Enum.Parse(typeof(ProfileEnum), profileAnswer.AnsweredOptions[0].Answer)
                                    : null;
                                break;
                            case "motivation":
                                var motivationAnswer = answer as MultipleChoiceAnswer;
                                respondant.Motivator = motivationAnswer.AnsweredOptions.Count == 1 ? motivationAnswer.AnsweredOptions[0].Answer : null;
                                break;
                            case "reasonNot":
                                var reasonNotAnswer = answer as MultipleChoiceAnswer;
                                respondant.Restrain = reasonNotAnswer.AnsweredOptions.Count == 1 ? reasonNotAnswer.AnsweredOptions[0].Answer : null;
                                break;
                            case "nngbMediumIntensity":
                                var nngbMediumIntesityAnswer = answer as MultipleChoiceAnswer;
                                nngbMediumIntensity = nngbMediumIntesityAnswer.AnsweredOptions.Count == 1 ? nngbMediumIntesityAnswer.AnsweredOptions[0].Answer : null;
                                break;
                            case "nngbHighIntensity":
                                var nngbHightIntesityAnswer = answer as MultipleChoiceAnswer;
                                nngbHighIntensity = nngbHightIntesityAnswer.AnsweredOptions.Count == 1 ? nngbHightIntesityAnswer.AnsweredOptions[0].Answer : null;
                                break;
                        }


                        if (respondant.Age <= 18)
                        {

                            switch (nngbMediumIntensity)
                            {
                                case "<60 min per week":
                                    satifiesMedium = false;
                                    break;
                                case "60-100 minuten per week":
                                    satifiesMedium = true;
                                    break;
                                case "101-150 min per week":
                                    satifiesMedium = true;
                                    break;
                                case ">150 min per week":
                                    satifiesMedium = true;
                                    break;
                            }

                            switch (nngbHighIntensity)
                            {
                                case "Gemiddeld minder dan 1 x per week":
                                    satifiesHigh = false;
                                    break;
                                case "1 tot 2 x per week":
                                    satifiesHigh = false;
                                    break;
                                case "3 of meer":
                                    satifiesHigh = true;
                                    break;
                            }
                        }
                        else
                        {
                            switch (nngbMediumIntensity)
                            {
                                case "<60 min per week":
                                    satifiesMedium = false;
                                    break;
                                case "60-100 minuten per week":
                                    satifiesMedium = false;
                                    break;
                                case "101-150 min per week":
                                    satifiesMedium = true;
                                    break;
                                case ">150 min per week":
                                    satifiesMedium = true;
                                    break;
                            }

                            switch (nngbHighIntensity)
                            {
                                case "Gemiddeld minder dan 1 x per week":
                                    satifiesHigh = false;
                                    break;
                                case "1 tot 2 x per week":
                                    satifiesHigh = true;
                                    break;
                                case "3 of meer":
                                    satifiesHigh = true;
                                    break;
                            }
                        }

                        if (satifiesMedium && satifiesHigh)
                        {
                            respondant.SatifiesNngb = true;
                        }
                    }
                }
            }

            return survey;
        }

        public void UpdateSurvey(Survey surveyToUpdate)
        {
            _dataBaseCalls.UpdateSurvey(surveyToUpdate);
        }
    }
}
