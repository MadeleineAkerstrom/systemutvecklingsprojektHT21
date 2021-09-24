using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public double MyBalance { get; set; } = 100;
        public MainViewModel Parent { get; }

        public PlayerViewModel()
        {
            
        }
    }
}
