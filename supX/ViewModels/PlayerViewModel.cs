using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public double MyBalance { get; set; } = 100;
        public string MyName { get; set; }


        public MainViewModel Parent { get; }

        public PlayerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            MyBalance = 100;
        }

        public PlayerViewModel()
        {
            MyBalance = 1500;
        }
    }
}
