using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateResultsModel
    {
        public FightViewModel GenerateResult(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            Random random = new Random();

            int typeOfFinish = random.Next(1, 4);
            int roundsToFinish;
            int winChance = 100;
            FightViewModel winner = new FightViewModel();

            // 1 in 3 chance the fight goes to decision.
            if (typeOfFinish != 3)
            {
                roundsToFinish = random.Next(1, 12);
            }
            else
            {
                roundsToFinish = 12;
            }
            // If the fight goes to desicion (12 rounds), every point in cardio adds 10% win chance and every point in speed adds 5%.
            if (roundsToFinish == 12)
            {
                winChance += (fighter1.Cardio * 20) - (fighter2.Cardio * 20);
                winChance += (fighter1.Speed * 10) - (fighter2.Speed * 10);
                winner.NumberOfRounds = 12;
            }
            // Else if the fight end in a KO or TKO; strength, speed and defense gives an edge.
            else
            {
                winChance += (fighter1.Strength * 20) - (fighter2.Strength * 20);
                winChance += (fighter1.Speed * 5) - (fighter2.Speed * 5);
                winChance += (fighter1.Defense * 20) - (fighter2.Defense * 20);
                // For every round it takes to finish the fight, additional win chance is added based on cardio.
                for (int i = 0; i < roundsToFinish; i++)
                {
                    winChance += (fighter1.Cardio * 2) - (fighter2.Cardio * 2);
                }
                winner.NumberOfRounds = roundsToFinish;
            }

            int win = random.Next(1, 100);

            if (win <= (winChance / 2))
            {
                winner.WinnerId = fighter1.Id;
                winner.WinnerName = fighter1.Name;
                winner.LoserName = fighter2.Name;
            }
            else
            {
                winner.WinnerId = fighter2.Id;
                winner.WinnerName = fighter2.Name;
                winner.LoserName = fighter1.Name;
            }

            return winner;
            
        }

        public bool GenerateBetResult(FighterViewModel myBet, FightViewModel winner)
        {
            if (myBet.Id == winner.WinnerId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
