using System;
using System.Collections.Generic;

namespace DataModels
{
    public class Survey
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime EndDate { get; set; }
        public string Owner { get; set; }
        public string ImageUrl { get; set; }
        public List<Page> Pages { get; set; }


    }
}
