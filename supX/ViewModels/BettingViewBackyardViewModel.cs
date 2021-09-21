using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class BettingViewBackyardViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public BettingViewBackyardViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
