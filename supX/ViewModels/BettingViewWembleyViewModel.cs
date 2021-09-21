using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class BettingViewWembleyViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public BettingViewWembleyViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
