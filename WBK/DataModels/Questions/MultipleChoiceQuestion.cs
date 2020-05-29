using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class MultipleChoiceQuestion : Question
    {
        public int MaximumNumberOfAnswers { get; set; }
        public List<MultipleChoiceOption> Options { get; set; }
    }
}
