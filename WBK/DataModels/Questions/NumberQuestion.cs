using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class NumberQuestion : Question
    {
        public double Minimum { get; set; }
        public double Maximum { get; set; }
    }
}
