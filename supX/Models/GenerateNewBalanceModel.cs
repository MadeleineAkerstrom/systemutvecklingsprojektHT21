using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.Models
{
    public class GenerateNewBalanceModel: BaseViewModel
    {

        public double MyBalance { get; set; } 
        public double BetAmount { get; set; }
        public double Odds { get; set; }
        public double NewBalance { get; set; }
        GenerateResultsModel generateResultsModel = new GenerateResultsModel();
      
        public double CalculateNewBalance(FighterViewModel myBet, FighterViewModel winner)
        {            
            double newBalance = NewBalance;        
            double myBalance = MyBalance;
            double betAmount = BetAmount;
            double odds = Odds;
            bool result = generateResultsModel.GenerateBetResult(myBet, winner);

            if (result == false)
            {
                newBalance = myBalance - betAmount;
            }
            else
            {
                newBalance = (betAmount * odds) + myBalance;
            }

            return newBalance;            
        }
    }
}
