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
            //soundsAndMusic.PlayWemblyIntro();
            sounds.PlayWemblyIntro();
            //soundsAndMusic.MediaPlayerTestingMethod();
        }

        public void MediaPlayerTestingMethodXX()
        {
            var mediaPlayer = new MediaPlayer();
            //Uri uri = new Uri(@".\Resources\fight.wav", UriKind.Relative);
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\Wembly Greetings.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 1.0;
            mediaPlayer.Play();
            //player.Volume = 0.3;
            //player.Open(PlayWemblyIntro);
            //mediaPlayer.Open(new System.Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\Wembly Greetings.wav"));
            //mediaPlayer.Open(new Uri(@".\Resources\Wembly Greetings.wav", UriKind.Relative));
            //mediaPlayer.Volume = 50.0;
            //mediaPlayer.Position.
            //mediaPlayer.Play(Properties.Resources.Wembly_Greetings);
            //new Uri(@".\Assets\Images\BackgroundBlixt_Test_white.png", UriKind.Relative)


        }
    }
}
