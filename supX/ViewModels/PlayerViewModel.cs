using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public static readonly Random random = new Random();

        public double MyBalance { get; set; }
        public string MyName { get; set; }

        public MainViewModel Parent { get; }

        public PlayerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;


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
        

        
       
        


    }
}
