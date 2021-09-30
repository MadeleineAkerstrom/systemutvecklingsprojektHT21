using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace supX.ViewModels
{
    public class LoserViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }

        public LoserViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
        public LoserViewModel(MainViewModel mainViewModel, double privatebalance)
        {
            Parent = mainViewModel;
            Parent.Player.MyBalance = privatebalance;
            sounds.PlayLosingGameSound();
        }
        
    }
}
