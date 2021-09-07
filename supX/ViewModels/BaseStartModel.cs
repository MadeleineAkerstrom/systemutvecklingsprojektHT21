using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class BaseStartModel : BaseViewModel
    {
        private string playerName = "anton";

        public string PlayerName 
        {
            get { return playerName; }
            set { playerName = value; }
        }

    }
}
