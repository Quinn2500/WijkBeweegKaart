using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Question
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public TypeEnum Type { get; set; }
        public CategoryEnum Category { get; set; }
        public Answer Answer { get; set; }
    }
}
