using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class FighterViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public FighterViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
