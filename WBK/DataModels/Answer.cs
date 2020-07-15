using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Answer
    {
        public int Id { get; set; }
        public Respondant Respondant { get; set; }
    }
}
