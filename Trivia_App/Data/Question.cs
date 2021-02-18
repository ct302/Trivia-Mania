using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Data
{
    public class Question
    {
        public string correctAnswer { get; set; }

        public string[] incorrectAnswers { get; set; }
    }
}
