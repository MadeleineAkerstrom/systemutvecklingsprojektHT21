using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : MainViewModel
    {
        public static readonly Random random = new Random();
        public List<FighterViewModel> fighters { get; set; }


        public PlayerViewModel()
        {
            GetRandomSeed();
        }

              

        /// <summary>
        /// Genrates a random number for Matchup
        /// </summary>
        public void GetRandomSeed()
        {
            //en match
            fighters = new List<FighterViewModel>();


            int seedNumber; /*= random.Next(6);*/

            foreach (var fighter in fighters)
            {
                seedNumber = random.Next(6);
                fighter.Id = seedNumber;   
                
            }
            
        }

        public void GenerateMatch(FighterViewModel fighter) 
        {
            //Här
            
        }


    }


}
