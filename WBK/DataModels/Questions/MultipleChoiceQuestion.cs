using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class MultipleChoiceQuestion : Question
    {
        public bool AllowMutlipleAnwsers { get; set; }
        public List<MultipleChoiceOption> Options { get; set; }
    }
}
