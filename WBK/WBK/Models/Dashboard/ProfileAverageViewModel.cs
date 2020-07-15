using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels;

namespace WBK.Models.Dashboard
{
    public class ProfileAverageViewModel
    {
        public List<Respondant> RespondantsWithProfile = new List<Respondant>();
        public int AverageAge { get; set; }
        public int PercentageThatSatifiesNNGB { get; set; }
        public int PercentageThatDoesSport { get; set; }
        public string BiggestMotivator { get; set; }
        public string BiggestRestrain { get; set; }
    }
}
