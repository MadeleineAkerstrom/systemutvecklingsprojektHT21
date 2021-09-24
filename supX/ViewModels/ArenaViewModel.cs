using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace supX.ViewModels
{
    public class ArenaViewModel : BaseViewModel
    {
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        //MediaPlayer mediaPlayer;
        
        public MainViewModel Parent { get; }

        public ArenaViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            sounds.PlayArenaIntroSound();                        
        }
    }
}
