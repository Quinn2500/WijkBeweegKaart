using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class MultipleChoiceOption
    {
        public MultipleChoiceOption(string answer, string description, string imageUrl)
        {
            Answer = answer;
            Description = description;
            ImageUrl = imageUrl;
        }

        public string Answer { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
