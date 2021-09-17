using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class BellagioViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public BellagioViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
