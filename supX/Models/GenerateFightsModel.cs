using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateFightsModel
    {
        public int[] GenerateFight(List<FighterViewModel> fighters)
        {
            int fighterCount = fighters.Count;
            int[] fighterIDs = new int[2];

            Random random = new Random();

            fighterIDs[0] = random.Next(0, fighterCount);
            do
            {
                fighterIDs[1] = random.Next(0, fighterCount);
            } while (fighterIDs[0] == fighterIDs[1]);

            return fighterIDs;
        }
    }
}
