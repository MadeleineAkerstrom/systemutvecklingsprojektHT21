using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class GameOverViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }

        public GameOverViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            sounds.PlayGameOverSound();
            Parent.Player.MyBalance = 100;
        }
    }
}
