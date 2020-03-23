using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class NumberQuestion : Question
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
}
