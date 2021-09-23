using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Media;

namespace supX.Sounds
{
    public class SoundsAndMusic
    {

        
        public SoundsAndMusic()
        {

        }

        public void MediaPlayerTestingMethod() 
        {
            var mediaPlayer = new MediaPlayer();
            Uri uri = new Uri(@".\Resources\fight.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
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


        #region SoundEffects
        /// <summary>
        /// Game Over sound
        /// </summary>
        public void PlayGameOverSound()
        {
            var player = new SoundPlayer(Properties.Resources.game_over);
            player.Play();
        }

        /// <summary>
        /// Intro sound for Game
        /// </summary>
        public void PlayIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.retro_intro);
            player.Play();
        }

        /// <summary>
        /// Sounds that starts a fight between two fighters
        /// </summary>
        public void PlayFightSound()
        {
            var player = new SoundPlayer(Properties.Resources.fight);
            player.Play();
        }

        /// <summary>
        /// Countdown befor a fight starts
        /// </summary>
        public void PlayCountDown()
        {
            var player = new SoundPlayer(Properties.Resources.robotic_countdown);
            player.Play();
        }

        /// <summary>
        /// Intro to Wembley
        /// </summary>
        public void PlayWemblyIntro()
        {
            var player = new SoundPlayer(Properties.Resources.Wembly_Greetings);
            player.Play();
        }

        /// <summary>
        /// Intro to Backyard
        /// </summary>
        public void PlayBackyardIntro()
        {
            var player = new SoundPlayer(Properties.Resources.Backyard_Greetings);
            player.Play();
        }

        /// <summary>
        /// Intro to Bellagio
        /// </summary>
        public void PlayBellagioIntro()
        {
            var player = new SoundPlayer(Properties.Resources.Bellagio_Greetings);
            player.Play();
        }

        /// <summary>
        /// Sound during a fight 
        /// </summary>
        public void PlayFightingSound()
        {
            var player = new SoundPlayer(Properties.Resources.karate_chop_long);
            player.Play();
        }

        /// <summary>
        /// Plays a loop
        /// </summary>
        public void PlayLooping()
        {
            SoundPlayer loop = new SoundPlayer(Properties.Resources.fight);
            loop.PlayLooping();
        }

        public void PlayArenaIntro() 
        {
            var player = new SoundPlayer(Properties.Resources.crowd_cheering_12s);
            player.Play();
        }

        #endregion



    }
}
