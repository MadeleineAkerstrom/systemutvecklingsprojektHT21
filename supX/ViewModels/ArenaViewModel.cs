using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class ArenaViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public ArenaViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
