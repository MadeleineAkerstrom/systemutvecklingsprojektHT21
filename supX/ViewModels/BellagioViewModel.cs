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
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }
        public BettingViewBellagioViewModel Betbell { get; set; }
        public FightViewModel Winner { get; set; }
        public ICommand Result { get; set; }
        private double privatebalance;
        public BellagioViewModel(MainViewModel mainViewModel)
        {
            sounds.PlayFightingSound();
            Parent = mainViewModel;
            Betbell = (BettingViewBellagioViewModel)mainViewModel.CurrentViewModel;
            Betbell.MyBetId = Betbell.GameEngine.SetMyBet(Betbell.BetAmount1, Betbell.BetAmount2, Betbell.FighterId1, Betbell.FighterId2);
            Winner = Betbell.GameEngine.GenerateResult(Betbell.GameEngine.fighter.fighters[Betbell.GameEngine.Fighter1.Id], Betbell.GameEngine.fighter.fighters[Betbell.GameEngine.Fighter2.Id]);
            Betbell.GameEngine.BetAmount=Betbell.GameEngine.SetBetAmount(Betbell.BetAmount1, Betbell.BetAmount2);
            Parent.Player.WinnerAmount = Betbell.GameEngine.WinnerAmount(Betbell.GameEngine.fighter.fighters[Betbell.MyBetId], Winner, Parent.Player.MyBalance);
            privatebalance = Betbell.GameEngine.CalculateNewBalance(Betbell.GameEngine.fighter.fighters[Betbell.MyBetId], Winner, Parent.Player.MyBalance); 
            Result = new RelyCommand(LostOrWon);
        }

        public void LostOrWon()
        {
            if (privatebalance == 0)
            {
                Parent.CurrentViewModel = new GameOverViewModel(Parent);
            }
            else
            {
                if (Betbell.MyBetId == Winner.WinnerId)
                {
                    Parent.CurrentViewModel = new WinnerViewModel(Parent, privatebalance);
                }

                else
                {
                    Parent.CurrentViewModel = new LoserViewModel(Parent, privatebalance);
                }
            }
        }

    }
}