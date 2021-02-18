using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trivia_App.Services;

namespace Trivia_App.Data
{
    public class CustomResults
    {
        
        public string Question { get; set; }

        public int ResultID { get; set; } = 1;
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string[]> ListOfAllAnswers { get; set; }







    }
}
