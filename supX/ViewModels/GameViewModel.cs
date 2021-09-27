using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using supX.Models;
using supX.Commands;
using supX.Data;


namespace supX.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        public string filename = new Uri(@".\Assets\Json\fighters.json", UriKind.Relative).ToString();
        public FighterViewModel fighter;
        public double[] Odds { get; set; }
        public int[] FighterIds { get; set; }
        public FighterViewModel Fighter1 { get; set; }
        public FighterViewModel Fighter2 { get; set; }
        public MainViewModel Parent { get; }
        ChangeViewCommand changeViewCommand;
        FighterViewModel fighterViewModel;
        BettingViewBellagioViewModel bettingViewBellagioView;
        public PlayerViewModel PlayerVM { get; set; }
        public double BetAmount { get; set; }
        public double BetOdds { get; set; }

        public GameViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            fighterViewModel = new FighterViewModel();
            bettingViewBellagioView = new BettingViewBellagioViewModel(Parent);

        }

        public GameViewModel()
        {

            Parent = new MainViewModel();
            OpenFile();
        }

        public void GenerateArena()
        {

            int[] fighterArray = GenerateFight(fighter.fighters);
            Odds = GenerateOdds(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            Fighter1 = fighter.fighters[fighterArray[0]];
            Fighter2 = fighter.fighters[fighterArray[1]];
        }

        public void GenerateFightResults()
        {
            FightViewModel winner = GenerateResult(Fighter1, Fighter2);

            int myBet = SetMyBet(bettingViewBellagioView.BetAmount1, bettingViewBellagioView.BetAmount2, Fighter1.Id, Fighter2.Id);

            GenerateBetResult(fighterViewModel.fighters[myBet], winner);
        }

        public bool EnoughBalance(double MyBalance, double BetAmount1, double BetAmount2)
        {
            if (BetAmount1 > MyBalance || BetAmount2 > MyBalance )
            {
                MessageBox.Show("Your balance is not enough. Try again!");
                Parent.CurrentViewModel = new BettingViewBellagioViewModel(null);
                return false;
            }
            else
            {

                return true;
            }
        }

        public int SetMyBet(double BetAmount1, double BetAmount2, int FighterId1, int FighterId2)
        {
            int MyBetId= 0;
            if (BetAmount1 != 0 && BetAmount2 != 0)
            {
                MessageBox.Show("You can't bet on both fighters, you idiot!");
                Parent.CurrentViewModel = new BettingViewBellagioViewModel(null);
                
            }
            else if (BetAmount1 == 0 && BetAmount2 == 0)
            {
                MessageBox.Show("You have to bet on someone, you idiot!");
                Parent.CurrentViewModel = new BettingViewBellagioViewModel(null);
            }
            else if (BetAmount1 != 0)
            {
                MyBetId = FighterId1;

              //  changeViewCommand.Execute(GotoView.BellagioView);
            }
            else
            {
                MyBetId = FighterId2;
               // changeViewCommand.Execute(GotoView.BellagioView);
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
            //double myBalance = Parent.Player.MyBalance;
            double betAmount = BetAmount;
            double odds = winner.WinnerOdds;
            bool result = GenerateBetResult(myBet, winner);

            if (result == false)
            {
                myBalance = myBalance - betAmount;
                MessageBox.Show("You lost");
                //Parent.CurrentViewModel = new LoserViewModel(null); 
                return myBalance;
            }
            else
            {
                myBalance = myBalance - betAmount;
                myBalance = (betAmount * odds) + myBalance;
                MessageBox.Show("You won");
                //Parent.CurrentViewModel = new WinnerViewModel(null);
                return myBalance;
            }

           
        }
        public double SetBetAmount(double betamount1, double betamount2)
        {
            double betamount;
            if (betamount1 >0)
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

            // Random rules for setting odds. Don't ask about it, it's just how it's calculated by the bookmaker..
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
