using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : MainViewModel
    {
        public double MyBalance { get; set; }
        public string MyName { get; set; }

        public PlayerViewModel()
        {
            MyBalance = 100;
            MyName = "Madde";

        }
    }


}
