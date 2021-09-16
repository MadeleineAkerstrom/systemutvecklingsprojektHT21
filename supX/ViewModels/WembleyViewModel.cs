using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class WembleyViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public WembleyViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
