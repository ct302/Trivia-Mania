using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trivia_App.Data;
namespace Trivia_App.Services
{
    public class SummaryService
    {
        public Summary mySummary { get; set; } = new Summary();
        public List<Summary> mySummaryList { get; set; } = new List<Summary>();


    }
}
