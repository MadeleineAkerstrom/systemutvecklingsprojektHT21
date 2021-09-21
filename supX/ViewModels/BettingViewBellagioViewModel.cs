using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class BettingViewBellagioViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public BettingViewBellagioViewModel( MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
