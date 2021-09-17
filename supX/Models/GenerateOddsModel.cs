using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateOddsModel
    {
        public double[] GenerateOdds(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            double[] oddsArray = new double[2];

            double winChangePercentage = 50;

            winChangePercentage += (fighter1.Strength - fighter2.Defense) * 5;
            winChangePercentage += (fighter1.Speed - fighter2.Defense) * 5;

            oddsArray[0] = 0.98 / (winChangePercentage / 100);
            oddsArray[1] = 0.98 / ((100 - winChangePercentage) / 100);

            return oddsArray;
        }

        public GenerateOddsModel()
        {

        }
    }
}
