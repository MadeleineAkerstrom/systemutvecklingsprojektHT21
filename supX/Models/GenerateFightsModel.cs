using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateFightsModel
    {
        public void GenerateFight()
        {
            List<FighterViewModel> fighters = new List<FighterViewModel>();

            int fighterCount = fighters.Count;
            int fighter1, fighter2;

            Random random = new Random();

            fighter1 = random.Next(0, fighterCount);
            do
            {
                fighter2 = random.Next(0, fighterCount);
            } while (fighter1 == fighter2);
        }
    }
}
