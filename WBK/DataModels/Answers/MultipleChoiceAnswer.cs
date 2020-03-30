using System;
using System.Collections.Generic;
using System.Text;
using DataModels.Questions;

namespace DataModels.Answers
{
    class MultipleChoiceAnswer : Answer
    {
        public List<MultipleChoiceOption> AnsweredOptions { get; set; }
    }
}
