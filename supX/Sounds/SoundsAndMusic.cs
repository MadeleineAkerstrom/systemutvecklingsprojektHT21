using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace supX.Sounds
{
    public class SoundsAndMusic
    {
        public SoundsAndMusic()
        {

        }


        #region SoundEffects
        /// <summary>
        /// Game Over sound
        /// </summary>
        public void PlayGameOverSound()
        {
            var player = new SoundPlayer(Properties.Resources.mixkit_sad_game_over_trombone_471_1_);
            player.Play();
        }

        /// <summary>
        /// Intro sound for Game
        /// </summary>
        public void PlayIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.mixkit_game_level_music_689_1_);
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
            //var player = new SoundPlayer(Properties.Resources.);
            //player.Play();
        }

        /// <summary>
        /// Intro to Backyard
        /// </summary>
        public void PlayBackyardIntro()
        {
            //var player = new SoundPlayer(Properties.Resources.);
            //player.Play();
        }

        /// <summary>
        /// Intro to Bellagio
        /// </summary>
        public void PlayBellagioIntro()
        {
            //var player = new SoundPlayer(Properties.Resources.);
            //player.Play();
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
        #endregion



    }
}
