using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public double MyBalance { get; set; }
        

        
        public MainViewModel Parent { get; }

        public PlayerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;            
            MyBalance = 100;            
        }
    }
}
