using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateNewBalanceModel: BaseViewModel
    {
        PlayerViewModel playerViewModel;
        FighterViewModel FighterViewModel;
        //public double MyBalance { get; set; } 
        public double BetAmount { get; set; }
        public double Odds { get; set; }
        //public double NewBalance { get; set; }
        GenerateResultsModel generateResultsModel = new GenerateResultsModel();

        public GenerateNewBalanceModel()
        {
            
        }
      
        public double CalculateNewBalance(FighterViewModel myBet, FightViewModel winner)
        {            
            //double newBalance = NewBalance;        
            double myBalance = playerViewModel.MyBalance;
            double betAmount = BetAmount;
            double odds = Odds;
            bool result = generateResultsModel.GenerateBetResult(myBet, winner);

            if (result == false)
            {
                myBalance += myBalance - betAmount;
            }
            else
            {
                myBalance += (betAmount * odds) + myBalance;
            }

            return myBalance;            
        }
    }
}
