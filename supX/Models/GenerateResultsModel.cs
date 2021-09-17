using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    class GenerateResultsModel
    {
        public FighterViewModel GenerateResult(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            Random random = new Random();

            int typeOfFinish = random.Next(1, 4);
            int roundsToFinish;
            int winChance = 100;
            FighterViewModel winner;

            // 1 in 3 chance the fight goes to decision.
            if (typeOfFinish != 3)
            {
                roundsToFinish = random.Next(1, 12);
            }
            else
            {
                roundsToFinish = 12;
            }
            // If the fight goes to desicion (12 rounds), every point in cardio adds 20% win chance and every point in speed adds 5%.
            if (roundsToFinish == 12)
            {
                winChance += (fighter1.Cardio*20) - (fighter2.Cardio*20);
                winChance += (fighter1.Speed * 5) - (fighter2.Speed * 5);
            }
            // Else if the fight end in a KO or TKO; strength, speed and defense gives an edge.
            else
            {
                winChance += (fighter1.Strength * 15) - (fighter2.Strength * 15);
                winChance += (fighter1.Speed * 10) - (fighter2.Speed * 10);
                winChance += (fighter1.Defense * 15) - (fighter2.Defense * 15);
            }

            int win = random.Next(1, 100);

            if (win <= (winChance / 2))
            {
                winner = fighter1;
            }
            else
            {
                winner = fighter2;
            }

            return winner;
            
        }
    }
}
