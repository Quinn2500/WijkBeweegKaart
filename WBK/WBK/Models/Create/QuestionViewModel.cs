﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;

namespace WBK.Models.Create
{
    public class QuestionViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TypeEnum Type { get; set; }
        public CategoryEnum Category { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int SliderScaleVal { get; set; }
        public string SliderMinText { get; set; }
        public string SliderMaxText { get; set; }
        public GeoTypeEnum GeoType { get; set; }
        public List<MultipleChoiceOptionViewModel> Options { get; set; }
        public bool AllowMultipleAnswers { get; set; }


    }
}
