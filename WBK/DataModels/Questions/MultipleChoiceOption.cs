using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class MultipleChoiceOption
    {
        public MultipleChoiceOption(string value, string description, string imageUrl)
        {
            Value = value;
            Description = description;
            ImageUrl = imageUrl;
        }

        public string Value { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
