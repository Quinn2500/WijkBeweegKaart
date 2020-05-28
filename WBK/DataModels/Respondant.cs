using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Respondant
    {
        public DateTime DateTimeOfCreation { get; set; }
        public string SessionId { get; set; }
        public ProfileEnum Profile { get; set; }
        public GenderEnum Gender { get; set; }
        public int Age { get; set; }
        public string PostCode { get; set; }
        public bool SatifiesNngb { get; set; }
        public bool DoesSport { get; set; }
        public bool Restrained { get; set; }
    }
}
