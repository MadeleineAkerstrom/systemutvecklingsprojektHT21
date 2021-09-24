using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using supX.Models;

namespace supX.ViewModels
{
    public class BellagioViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }
        public BettingViewBellagioViewModel Betbell { get; set; }
        public FighterViewModel FightVM { get; set; }
        public PlayerViewModel PlayerVM { get; set; }

        public BellagioViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            Betbell = (BettingViewBellagioViewModel)mainViewModel.CurrentViewModel;
          

            Betbell.MyBetId = Betbell.GameVM.SetMyBet(Betbell.BetAmount1, Betbell.BetAmount2, Betbell.FighterId1, Betbell.FighterId2);
            //FightViewModel winner = GameVM.GenerateResult(FightVM.fighters[GameVM.Fighter1.Id], FightVM.fighters[GameVM.Fighter2.Id]);
            //Thread.Sleep(5000);
            //PlayerVM.MyBalance = GameVM.CalculateNewBalance(FightVM.fighters[MyBet], winner);
        }
        //public BellagioViewModel(MainViewModel parent, GameViewModel gameVM, BettingViewBellagioViewModel betbell) : this(parent)
        //{
        //    GameVM = gameVM;
        //    Betbell = betbell;
        //}
    }
}