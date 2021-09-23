using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using supX.Commands;
using supX.Data;

namespace supX.ViewModels
{
    public class BettingViewBellagioViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }
        public double BetAmount1 { get; set; }
        public double BetAmount2 { get; set; }
        public int MyBetId { get; set; }
        public int FighterId1 { get; set; }
        public int FighterId2 { get; set; }
        public BettingViewBellagioViewModel betbell;

        ChangeViewCommand changeViewCommand;

        public BettingViewBellagioViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            GameVM = new GameViewModel();

            GameVM.GenerateArena();
            FighterId1 = GameVM.Fighter1.Id;
            FighterId2 = GameVM.Fighter2.Id;
        }
    }
}