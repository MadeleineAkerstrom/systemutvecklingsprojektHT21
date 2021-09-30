﻿using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using supX.Commands;
using supX.Data;
using System.Windows.Input;

namespace supX.ViewModels
{
    public class BettingViewBellagioViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }
        public GameEngineModel GameEngine { get; set; }
        public FighterViewModel FighterVM { get; set; }
        public BettingViewBellagioViewModel betbell;
        public double BetAmount1 { get; set; }
        public double BetAmount2 { get; set; }
        public int MyBetId { get; set; } = 0;
        public int FighterId1 { get; set; }
        public int FighterId2 { get; set; }
        public bool btnEnabled { get; set; }
        public ICommand CheckEnoughBalance { get; set; }

        public BettingViewBellagioViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            sounds.PlayBellagioIntroSound();
            btnEnabled = false;
            GameEngine = new GameEngineModel();
            FighterVM = new FighterViewModel();
            GameEngine.GenerateArena();
            FighterId1 = GameEngine.Fighter1.Id;
            FighterId2 = GameEngine.Fighter2.Id;
            CheckEnoughBalance = new RelyCommand(EnoughBalance);
        }

        /// <summary>
        /// Method that checks if player has sufficent balance to place a bet
        /// </summary>
        private void EnoughBalance()
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
                sounds.PlayCashRegisterSound();
            }
        }
    }
}