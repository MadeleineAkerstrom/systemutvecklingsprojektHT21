using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace supX.ViewModels
{
    public class BettingViewWembleyViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }

        public BettingViewWembleyViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            GameVM = new GameViewModel();
        }

    }
}