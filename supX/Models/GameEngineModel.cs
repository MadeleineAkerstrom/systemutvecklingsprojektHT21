﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using supX.ViewModels;

namespace supX.Models
{
    public class GameEngineModel
    {
        public string filename = new Uri(@".\Assets\Json\fighters.json", UriKind.Relative).ToString();
        public FighterViewModel fighter;
        public FighterViewModel fighterViewModel;
        public double[] Odds { get; set; }
        public int[] FighterIds { get; set; }
        public FighterViewModel Fighter1 { get; set; }
        public FighterViewModel Fighter2 { get; set; }
        public MainViewModel Parent { get; }
        public PlayerViewModel PlayerVM { get; set; }
        public double BetAmount { get; set; }
        public double BetOdds { get; set; }

        public GameEngineModel()
        {
            fighterViewModel = new FighterViewModel();
            OpenFile();
        }

        public void GenerateArena()
        {
            int[] fighterArray = GenerateFight(fighter.fighters);
            Odds = GenerateOdds(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            Fighter1 = fighter.fighters[fighterArray[0]];
            Fighter2 = fighter.fighters[fighterArray[1]];
        }

        public int SetMyBet(double BetAmount1, double BetAmount2, int FighterId1, int FighterId2)
        {
            int MyBetId = 0;
            if (BetAmount1 <= 0 && BetAmount2 <= 0)
            {
                MessageBox.Show("You have to bet on someone, you idiot!");
                Parent.CurrentViewModel = new BettingViewBellagioViewModel(null);
            }
            else if (BetAmount1 > 0)
            {
                MyBetId = FighterId1;
            }
            else
            {
                MyBetId = FighterId2;
            }
            return MyBetId;
        }

        public int[] GenerateFight(List<FighterViewModel> fighters)
        {
            int fighterCount = fighters.Count;
            int[] fighterIDs = new int[2];

            Random random = new Random();

            fighterIDs[0] = random.Next(0, fighterCount);
            do
            {
                fighterIDs[1] = random.Next(0, fighterCount);
            } while (fighterIDs[0] == fighterIDs[1]);

            return fighterIDs;
        }





        public double CalculateNewBalance(FighterViewModel myBet, FightViewModel winner, double myBalance)
        {
            double betAmount = BetAmount;
            double odds = winner.WinnerOdds;
            bool result = GenerateBetResult(myBet, winner);

            if (result == false)
            {
                myBalance = myBalance - betAmount;
                return Math.Round(myBalance);
            }
            else
            {
                myBalance = myBalance - betAmount;
                myBalance = (betAmount * odds) + myBalance;
                return Math.Round(myBalance);
            }


        }
        public double SetBetAmount(double betamount1, double betamount2)
        {
            double betamount;
            if (betamount1 > 0)
            {
                betamount = betamount1;
            }
            else
            {
                betamount = betamount2;
            }
            return betamount;

        }

        public double[] GenerateOdds(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            double[] oddsArray = new double[2];
            double winChangePercentage = 50;

            winChangePercentage += (fighter1.Strength - fighter2.Defense) * 5;
            winChangePercentage += (fighter1.Speed - fighter2.Strength) * 3;
            winChangePercentage += (fighter1.Cardio - fighter2.Cardio) * 1;

            oddsArray[0] = Math.Round(0.95 / (winChangePercentage / 100), 2);
            oddsArray[1] = Math.Round(0.95 / ((100 - winChangePercentage) / 100), 2);

            return oddsArray;
        }

        public FightViewModel GenerateResult(FighterViewModel fighter1, FighterViewModel fighter2)
        {
            Random random = new Random();

            int typeOfFinish = random.Next(1, 4);
            int roundsToFinish;
            int winChance = 100;
            FightViewModel winner = new FightViewModel();

            // 1 in 3 chance the fight goes to decision.
            if (typeOfFinish != 3)
            {
                roundsToFinish = random.Next(1, 12);
            }
            else
            {
                roundsToFinish = 12;
            }
            // If the fight goes to desicion (12 rounds), every point in cardio adds 10% win chance and every point in speed adds 5%.
            if (roundsToFinish == 12)
            {
                winChance += (fighter1.Cardio * 20) - (fighter2.Cardio * 20);
                winChance += (fighter1.Speed * 10) - (fighter2.Speed * 10);
                winner.NumberOfRounds = 12;
            }
            // Else if the fight end in a KO or TKO; strength, speed and defense gives an edge.
            else
            {
                winChance += (fighter1.Strength * 20) - (fighter2.Strength * 20);
                winChance += (fighter1.Speed * 5) - (fighter2.Speed * 5);
                winChance += (fighter1.Defense * 20) - (fighter2.Defense * 20);
                // For every round it takes to finish the fight, additional win chance is added based on cardio.
                for (int i = 0; i < roundsToFinish; i++)
                {
                    winChance += (fighter1.Cardio * 2) - (fighter2.Cardio * 2);
                }
                winner.NumberOfRounds = roundsToFinish;
            }

            int win = random.Next(1, 100);

            if (win <= (winChance / 2))
            {
                winner.WinnerId = fighter1.Id;
                winner.WinnerName = fighter1.Name;
                winner.LoserName = fighter2.Name;
                winner.WinnerOdds = Odds[0];
            }
            else
            {
                winner.WinnerId = fighter2.Id;
                winner.WinnerName = fighter2.Name;
                winner.LoserName = fighter1.Name;
                winner.WinnerOdds = Odds[1];
            }

            return winner;

        }

        public bool GenerateBetResult(FighterViewModel myBet, FightViewModel winner)
        {
            if (myBet.Id == winner.WinnerId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void OpenFile()
        {
            fighter = FileHandler.FileHandler.Open<FighterViewModel>(filename);
        }

    }
}