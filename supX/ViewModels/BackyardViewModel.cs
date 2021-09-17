using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class BackyardViewModel: BaseViewModel
    {
        public MainViewModel Parent { get; }

        public BackyardViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
