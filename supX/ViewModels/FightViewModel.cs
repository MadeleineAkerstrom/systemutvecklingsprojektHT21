using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class FightViewModel
    {
        public int WinnerId { get; set; }
        public string WinnerName { get; set; }
        public string LoserName { get; set; }
        public int NumberOfRounds { get; set; }
        public double WinnerOdds { get; set; }
    }
}
