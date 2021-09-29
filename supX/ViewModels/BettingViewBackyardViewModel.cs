using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using supX.Commands;
using supX.Data;
using System.Windows.Input;
using System.Windows.Controls;

namespace supX.ViewModels
{
    public class BettingViewBackyardViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }
        public FighterViewModel FighterVM { get; set; }

        public double BetAmount1 { get; set; }
        public double BetAmount2 { get; set; }
        public int MyBetId { get; set; } = 0;
        public int FighterId1 { get; set; }
        public int FighterId2 { get; set; }
        public BettingViewBackyardViewModel betback;
        public bool btnEnabled { get; set; }

        public ICommand CheckEnoughBalance { get; set; }

        public BettingViewBackyardViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;


            sounds.PlayBackyardIntroSound();

            btnEnabled = false;
            GameVM = new GameViewModel();
            FighterVM = new FighterViewModel();
            GameVM.GenerateArena();
            FighterId1 = GameVM.Fighter1.Id;
            FighterId2 = GameVM.Fighter2.Id;
            CheckEnoughBalance = new RelyCommand(EnoughBalance);
            
        }

        public void EnoughBalance()
        {
            if (BetAmount1 + BetAmount2 > Parent.Player.MyBalance)
            {
                MessageBox.Show("Your balance is not enough. Try again!");
                BetAmount1 = 0;
                BetAmount2 = 0;
            }
            else
            {
                btnEnabled = true;
            }
        }
    }
}