using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WBK.Models.Create
{
    public class PageViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<QuestionViewModel> Questions { get; set; }
        public string ImageUrl { get; set; }
    }
}
