using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class FighterViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Cardio { get; set; }
        public int Speed { get; set; }
        public int Defense { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public string ImagePath { get; set; }

        public List<FighterViewModel> fighters { get; set; }
        //public MainViewModel Parent { get; }
        public FighterViewModel(/*MainViewModel mainViewModel*/)
        {
            fighters = new List<FighterViewModel>();
            //Parent = mainViewModel;
        }


        public override string ToString() 
        {
            return $"{Name} {Wins} {Losses}";
        }

    

        
    }
}
