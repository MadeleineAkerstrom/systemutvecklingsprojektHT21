using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace supX.ViewModels
{
    public class WembleyViewModel : BaseViewModel
    {
        //Sounds.SoundsAndMusic soundsAndMusic = new Sounds.SoundsAndMusic();
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();

        public MainViewModel Parent { get; }

        public WembleyViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }

       
    }
}
