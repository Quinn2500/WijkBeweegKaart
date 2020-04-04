using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class SurveyAnswers
    {
        public string SurveyTitle { get; set; }
        public List<Question> Questions { get; set; }
    }
}
