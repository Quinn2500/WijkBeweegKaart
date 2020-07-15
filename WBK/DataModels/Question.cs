﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Question
    {
        public int Id { get; set; }
        public int QuestionNumber { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public TypeEnum Type { get; set; }
        public CategoryEnum Category { get; set; }
        public string Attribute { get; set; }
        public bool IsRequired { get; set; }
        public List<Answer> Answers { get; set; }
        public string ImageUrl { get; set; }
    }
}
