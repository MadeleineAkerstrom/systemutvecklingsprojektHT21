using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class ShowResultViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public BellagioViewModel BellV { get; set; }
        public string Result { get; set; }

        public ShowResultViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            BellV = (BellagioViewModel)mainViewModel.CurrentViewModel;
            //LostOrWon();
        }

        //public void LostOrWon()
        //{
        //    string winner = "/Assets/Images/Icons/WinnerIcon.png";
        //    string loser = "/Assets/Images/Backgrounds/game-lose.jpg";
           
        //    if (BellV.Betbell.MyBetId == BellV.Betbell.GameVM.fighter.fighters[BellV.Winner.WinnerId].Id)
        //    {
        //        Result = winner;
        //    }
        //    else
        //    {
        //        Result = loser;
        //    }
        //}
    }
}
