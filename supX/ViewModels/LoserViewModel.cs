using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace supX.ViewModels
{
    public class LoserViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic soundsAndMusic = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }

        public LoserViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            soundsAndMusic.PlayGameOverSound();
        }
        
    }
}
