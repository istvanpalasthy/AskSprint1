using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskSprint1
{
    public class Questions
    {
        string question { get; set; }
        string answer { get; set; }
        public Questions(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
