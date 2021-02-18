using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Data
{
    public class Summary
    {
        public bool AnsweredCorrectly { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string YourAnswer{ get; set; }
        public string AnswerStatus { get; set; }


    }
}
