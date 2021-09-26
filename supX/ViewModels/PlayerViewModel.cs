using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        //public double MyBalance { get; set; } = 100;
        //private double myBalance; 
        //public double MyBalance
        //{
        //    get { return myBalance; }
        //    set { myBalance = value; }
        //}

        public double MyBalance { get; set; }


        public MainViewModel Parent { get; }

        public PlayerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            //var myBalance = MyBalance;
        }
        
        
        
    }

   

}
