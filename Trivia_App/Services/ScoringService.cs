using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Services
{
    public class ScoringService
    {
        public int score = 0;

        public int amountOfQuestionsWrong { get; set; }
        public int amountOfQuestionsCorrect { get; set; }

        public bool isGameOver { get; set; }


    }
}
