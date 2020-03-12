using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBK.Models.Create
{
    public class PageViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
    }
}
