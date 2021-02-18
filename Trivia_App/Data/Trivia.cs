using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Data
{
    public class Trivia
    {
        public int Response_code { get; set; }
        public Result[] Results { get; set; }


        public class Result
        {
            public string Category { get; set; }
            public string Type { get; set; }
            public string Difficulty { get; set; }
            public string Question { get; set; }
            public string Correct_answer { get; set; }
            public string[] Incorrect_answers { get; set; } 
            public int ResultID { get; set; }


        }


    }
}
