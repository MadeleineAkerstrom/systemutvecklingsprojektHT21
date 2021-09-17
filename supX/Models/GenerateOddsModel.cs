using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateOddsModel
    {
        public int[] GenerateOdds(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            int[] oddsArray = new int[2];

            int winChangePercentage = 50;

            winChangePercentage = +(fighter1.Strength - fighter2.Defense) * 10;
            winChangePercentage = +(fighter1.Cardio - fighter2.Cardio) * 10;
            winChangePercentage = +(fighter1.Speed - fighter2.Defense) * 10;

            oddsArray[0] = 1 / (winChangePercentage / 100);
            oddsArray[1] = 1 / ((100 - winChangePercentage) / 100);

            return oddsArray;
        }

        public GenerateOddsModel()
        {

        }
    }
}
