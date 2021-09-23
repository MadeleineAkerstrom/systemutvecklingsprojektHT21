using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace supX.ViewModels
{
    public class BettingViewBackyardViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }

        public int MyBet { get; set; }
        public string BetAmount { get; set; } = "100";

        public BettingViewBackyardViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            GameVM = new GameViewModel();
        }
    }
}