using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace supX.ViewModels
{
    public class BettingViewBellagioViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }

        public BettingViewBellagioViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            GameVM = new GameViewModel();
        }
    }
}