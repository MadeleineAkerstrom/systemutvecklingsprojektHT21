using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class WinnerViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }

        public WinnerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;            
        }

        public WinnerViewModel(MainViewModel mainViewModel, double privatebalance)
        {
            Parent = mainViewModel;
            Parent.Player.MyBalance = privatebalance;
            sounds.PlayWinnerGameSound();
        }
    }
}
