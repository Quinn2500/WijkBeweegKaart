using System;
using System.Collections.Generic;
using System.Text;
using DataModels.Questions;

namespace DataModels.Answers
{
    public class MultipleChoiceAnswer : Answer
    {
        public List<MultipleChoiceOption> AnsweredOptions { get; set; }

        public override string ToString()
        {
            string result = "";
            foreach (MultipleChoiceOption option in AnsweredOptions)
            {
                if (!string.IsNullOrEmpty(option.ImageUrl))
                {
                    result = result + " Antwoord: " + option.Answer + " Afbeelding URL: " + option.ImageUrl;
                }
                else
                {
                    result = result + option.Answer;
                }
            }

            return result;

        }
    }
}
