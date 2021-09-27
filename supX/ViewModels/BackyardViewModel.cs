using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;
using supX.Commands;
using supX.Models;

namespace supX.ViewModels
{
    public class BackyardViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }
        public BettingViewBackyardViewModel Betback { get; set; }
        public FighterViewModel FightVM { get; set; }
        public FightViewModel Winner { get; set; }
        public ICommand Result { get; set; }
        public PlayerViewModel PlayerVM { get; set; }

        public BackyardViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            Betback = (BettingViewBackyardViewModel)mainViewModel.CurrentViewModel;

            Result = new RelyCommand(LostOrWon);
            Betback.MyBetId = Betback.GameVM.SetMyBet(Betback.BetAmount1, Betback.BetAmount2, Betback.FighterId1, Betback.FighterId2);
            Winner = Betback.GameVM.GenerateResult(Betback.GameVM.fighter.fighters[Betback.GameVM.Fighter1.Id], Betback.GameVM.fighter.fighters[Betback.GameVM.Fighter2.Id]);
            Betback.GameVM.BetAmount = Betback.GameVM.SetBetAmount(Betback.BetAmount1, Betback.BetAmount2);
            //Thread.Sleep(5000);
            Parent.Player.MyBalance = Betback.GameVM.CalculateNewBalance(Betback.GameVM.fighter.fighters[Betback.MyBetId], Winner, Parent.Player.MyBalance); //Here
        }

        public void LostOrWon()
        {

            if (Betback.MyBetId == Winner.WinnerId)
            {

                Parent.CurrentViewModel = new WinnerViewModel(Parent);
            }
            else
            {
                Parent.CurrentViewModel = new LoserViewModel(Parent);
            }
        }

    }
}