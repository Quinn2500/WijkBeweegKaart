using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Questions
{
    public class SliderQuestion : Question
    {
        public string MaxValueText { get; set; }
        public string MinValueText { get; set; }
        public int Scale { get; set; }
    }
}
