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
        public GameEngineModel GameEngine { get; set; }
        public FighterViewModel FighterVM { get; set; }
        public BettingViewBackyardViewModel betback;
        public double BetAmount1 { get; set; }
        public double BetAmount2 { get; set; }
        public int MyBetId { get; set; } = 0;
        public int FighterId1 { get; set; }
        public int FighterId2 { get; set; }
        public bool btnEnabled { get; set; }
        public ICommand CheckEnoughBalance { get; set; }

        public BettingViewBackyardViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            sounds.PlayBackyardIntroSound();
            btnEnabled = false;
            GameEngine = new GameEngineModel();
            FighterVM = new FighterViewModel();
            GameEngine.GenerateArena();
            FighterId1 = GameEngine.Fighter1.Id;
            FighterId2 = GameEngine.Fighter2.Id;
            CheckEnoughBalance = new RelyCommand(EnoughBalance);
        }

        public bool ChangeInput(double betAmount1, double betAmount2) 
        {
            string a = BetAmount1.ToString();
            string b = BetAmount2.ToString();
            if (IsDigitsOnly(a) && IsDigitsOnly(b))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public void EnoughBalance()
        {
            if (BetAmount1 + BetAmount2 > Parent.Player.MyBalance || ChangeInput(1, 2) == true)
            {
                MessageBox.Show("Your balance is not enough. Try again!");
                BetAmount1 = 0;
                BetAmount2 = 0;
            }
            else
            {
                btnEnabled = true;
                sounds.PlayCashRegisterSound();
            }
        }

    }
}