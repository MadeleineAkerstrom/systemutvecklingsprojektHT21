using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class RulesViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public RulesViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
