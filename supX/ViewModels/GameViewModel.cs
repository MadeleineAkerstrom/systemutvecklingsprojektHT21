using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }

        public GameViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
