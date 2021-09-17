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

       

        public GenerateNewBalanceModel()
        {

        }
    }
}
