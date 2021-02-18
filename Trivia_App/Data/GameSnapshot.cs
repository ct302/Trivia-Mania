using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Data
{
    public class GameSnapshot 
    {

        [Key]
        public Guid GameID { get; set; } = Guid.NewGuid();

        public string UserID { get; set; } 
        
        public string GameDifficulty { get; set; }
        public string GameCategory { get; set; }
        public int GameLength { get; set; }
        public string CorrectAnswers { get; set; }
        public string IncorrectAnswers { get; set; }

        public double GameScorePercentage { get; set; }
        public string DatePlayed { get; set; }
        public string TimePlayed { get; set; }


    }
}
