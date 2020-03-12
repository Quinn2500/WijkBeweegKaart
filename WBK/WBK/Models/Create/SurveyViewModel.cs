using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;

namespace WBK.Models.Create
{
    public class SurveyViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StartLocationLat { get; set; }
        public string StartLocationLong { get; set; }
        public DateTime EndDate { get; set; }
    }
}
