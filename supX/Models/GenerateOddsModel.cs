using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateOddsModel
    {
        
        public void GenerateOdds(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            int winChangePercentage = 50;

            winChangePercentage = +(fighter1.Strength - fighter2.Defense) * 10;
            winChangePercentage = +(fighter1.Cardio - fighter2.Cardio) * 10;
            winChangePercentage = +(fighter1.Speed - fighter2.Defense) * 10;

            double odds1 = (winChangePercentage / 100) + 1;
            double odds2 = 100 - (winChangePercentage / 100) + 1;

        }

        public GenerateOddsModel()
        {
            
        }
    }
}
