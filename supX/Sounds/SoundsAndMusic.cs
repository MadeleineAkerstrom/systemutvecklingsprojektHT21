using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Windows.Media;

namespace supX.Sounds
{
    public class SoundsAndMusic
    {

        MediaPlayer mediaPlayer = new MediaPlayer();

        public SoundsAndMusic()
        {
            
        }
     


        #region SoundEffects
        /// <summary>
        /// Plays when Game Over
        /// </summary>
        public void PlayGameOverSound()
        {
            var player = new SoundPlayer(Properties.Resources.GameOverMelody);
            player.Play();
        }

        /// <summary>
        /// Intro sound for Game
        /// </summary>
        public void PlayIntroSound()
        {
            SoundPlayer loop = new SoundPlayer(Properties.Resources.retroLowSound);
            loop.PlayLooping();
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
        public void PlayCountDownSound()
        {
            var player = new SoundPlayer(Properties.Resources.robotic_countdown);
            player.Play();
        }

        /// <summary>
        /// Intro to Wembley
        /// </summary>
        public void PlayWemblyIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.WembleyGreetingsWithApplause);
            player.Play();
        }

        /// <summary>
        /// Intro to Backyard
        /// </summary>
        public void PlayBackyardIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.BackyardGreetingsWithApplause);
            player.Play();
        }

        /// <summary>
        /// Intro to Bellagio
        /// </summary>
        public void PlayBellagioIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.BellagioGreetingsWithApplause);
            player.Play();
        }

        /// <summary>
        /// Sound during a fight 
        /// </summary>
        public void PlayFightingSound()
        {
            var player = new SoundPlayer(Properties.Resources.PlayFighting);
            player.Play();
        }

        /// <summary>
        /// Plays a loop
        /// </summary>
        public void PlayLoopingSound()
        {
            SoundPlayer loop = new SoundPlayer(Properties.Resources.fight);
            loop.PlayLooping();
        }

        /// <summary>
        /// Plays the Arena sound as a loop
        /// </summary>
        public void PlayArenaIntroSound() 
        {
            SoundPlayer loop  = new SoundPlayer(Properties.Resources.PlayArenaIntroSoundLowSound);
            loop.PlayLooping();
        }

        #endregion



    }
}
