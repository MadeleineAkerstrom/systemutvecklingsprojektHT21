using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class ArenaViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic soundsAndMusic = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }

        public ArenaViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            soundsAndMusic.PlayArenaIntro();
        }
    }
}
