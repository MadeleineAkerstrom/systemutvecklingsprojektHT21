using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public double MyBalance { get; set; }
     
        public PlayerViewModel()
        {
            MyBalance = 100;
        }
    }
}
