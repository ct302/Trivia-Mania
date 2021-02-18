using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Services
{
    public class DifficultyService
    {

        public string IsEasySelected => !isEasyChecked ? null : "Easy";
        public string IsMediumSelected => !isMediumChecked ? null : "Medium";
        public string IsHardSelected => !isHardChecked ? null : "Hard";


        public string GetFinalDifficultySelection()
        {
            string finalDifficulty = "";

            if (IsEasySelected != null)
            {
                finalDifficulty = "easy";
            }
            else if (IsMediumSelected != null)
            {
                finalDifficulty = "medium";
            }

            else if (IsHardSelected != null)
            {
                finalDifficulty = "hard";
            }

            return finalDifficulty;

        }


        public bool isEasyChecked = false;
        public bool isMediumChecked = false;
        public bool isHardChecked = false;

        public bool WasDifficultySelected => isEasyChecked || isMediumChecked || isHardChecked == true;

       


    }
}
