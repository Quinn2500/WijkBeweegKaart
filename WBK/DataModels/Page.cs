using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Page
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }
        public string ImageUrl { get; set; }
    }
}
