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

        public MainViewModel Parent { get; }
        public List<FighterViewModel> fighters { get; set; }

        public FighterViewModel(MainViewModel mainViewModel)
        {

            Parent = mainViewModel;


        }

        //public FighterViewModel()
        //{
        //    fighters = new List<FighterViewModel>(); //lista skapad i ctor
        //}



        //public FighterViewModel()
        //{
        //    fighters = new List<FighterViewModel>(); //lista skapad i ctor
        //}


        public override string ToString() //Annars kommer inte namnet i listan över trollkarlar, samma som comboboxen
        {
            return $"{Name} {Wins} {Losses}";
        }
    }
}
