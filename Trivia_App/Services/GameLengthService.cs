using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia_App.Services
{
    public class GameLengthService
    {



        public int VeryShortGame = 5;

        public int ShortGame = 10;

        public int MediumGame = 25;

        public int LongGame = 50;

        public int chosenGameLength;

        public int finalChosenGameLength;

        public bool wasGameLengthSelected = false;

        public void GetGameLength()
        {
            if (chosenGameLength == 2)
            {
                
            }

            else
            {
                if (chosenGameLength == ShortGame)
                {
                    finalChosenGameLength = ShortGame;
                    wasGameLengthSelected = true;

                }
                else if (chosenGameLength == VeryShortGame)
                {
                    finalChosenGameLength = VeryShortGame;
                    wasGameLengthSelected = true;
                }

                else if (chosenGameLength == MediumGame)
                {
                    finalChosenGameLength = MediumGame;
                    wasGameLengthSelected = true;


                }

                else if (chosenGameLength == LongGame)
                {
                    finalChosenGameLength = LongGame;
                    wasGameLengthSelected = true;


                }
            }
        }


    }
}
