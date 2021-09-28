using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class WinnerViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic soundsAndMusic = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }

        public WinnerViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            soundsAndMusic.PlayWinnerGameSound();
        }
    }
}
