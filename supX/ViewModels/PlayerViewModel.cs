using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public static readonly Random random = new Random();
        /*public List<FighterViewModel> fighters { get; set; }*/ //verkar rätt
        public ObservableCollection<FighterViewModel> Fighter { get; set; }

        public PlayerViewModel()
        {
            
            //GetRandomSeed();
        }

        //public void GetFightersFromSave() 
        //{
        //    fighters = new List<FighterViewModel>();
        
        
        
        //}
        //public List<FighterViewModel> ShowFighters() 
        //{
        //    //var fighters = new List<FighterViewModel>();
        //    fighters = new FighterViewModel
        //    {

        //    };
        //    fighters.Add(Fighter)

        //}      
        public double MyBalance { get; set; }
        public string MyName { get; set; }

        //public List<FighterViewModel> ShowFighters() 
        //{ 
            
        
        
        //}

        /// <summary>
        /// Genrates a random number for Matchup
        /// </summary>
        //public void GetRandomSeed()
        //{
        //    //en match
        //    fighters = new List<FighterViewModel>();


        //    int seedNumber; /*= random.Next(6);*/

        //    foreach (var fighter in fighters)
        //    {
        //        seedNumber = random.Next(6);
        //        fighter.Id = seedNumber;   
                
        //    }
            
        //}
       
        public MainViewModel Parent { get; }

        public PlayerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            MyBalance = 100;
            MyName = "Madde";
        }


    }
}
