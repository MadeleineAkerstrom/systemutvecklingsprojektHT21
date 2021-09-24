using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;
using supX.Commands;
using supX.Models;

namespace supX.ViewModels
{
    public class BellagioViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }
        public BettingViewBellagioViewModel Betbell { get; set; }
        public FighterViewModel FightVM { get; set; }
        public FightViewModel Winner { get; set; }
        public ICommand Result { get; set; }

        public BellagioViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            Betbell = (BettingViewBellagioViewModel)mainViewModel.CurrentViewModel;
           
            Result = new RelyCommand(LostOrWon);          
            Betbell.MyBetId = Betbell.GameVM.SetMyBet(Betbell.BetAmount1, Betbell.BetAmount2, Betbell.FighterId1, Betbell.FighterId2);
            FightViewModel Winner = Betbell.GameVM.GenerateResult(Betbell.GameVM.fighter.fighters[Betbell.GameVM.Fighter1.Id], Betbell.GameVM.fighter.fighters[Betbell.GameVM.Fighter2.Id]);
            //Thread.Sleep(5000);
            //Betbell.GameVM.PlayerVM.MyBalance = Betbell.GameVM.CalculateNewBalance(Betbell.GameVM.fighter.fighters[Betbell.MyBetId], Winner);
        }

        public void LostOrWon()
        {
            
            if (Betbell.MyBetId == Winner.WinnerId)
            {

                Parent.CurrentViewModel = new WinnerViewModel(null);
            }
            else
            {
                Parent.CurrentViewModel = new LoserViewModel(null);
            }
        }

    }
}