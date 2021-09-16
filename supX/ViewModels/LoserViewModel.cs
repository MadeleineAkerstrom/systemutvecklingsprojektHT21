using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class LoserViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public LoserViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
