using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Services
{
    public class DisplayAnswerService
    {

        public bool wasAnswerClicked = false;

        public string correctAnswer = "";

        public string[] incorrectAnswers = new string[3];

        public Dictionary<string, string[]> answerDict = new Dictionary<string, string[]>();

        public List<string> allAnswers = new List<string>();


    }
}
