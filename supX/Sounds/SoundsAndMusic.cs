﻿using supX.ViewModels;
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

        public void StopSound() 
        {
            mediaPlayer.Stop();
        }

        #region MediaPlayer

        /// <summary>
        /// Plays when Game Over
        /// </summary>
        public void PlayGameOver() 
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\GameOverMelody.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 0.02;
            mediaPlayer.Play();

        }

        /// <summary>
        /// Plays Intro music for the game
        /// </summary>
        public void PlayIntro()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\retro.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 0.02;
            mediaPlayer.Play();           

        }

        /// <summary>
        /// Sounds that starts a fight between two fighters
        /// </summary>
        public void PlayFight()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\fight.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 0.02;
            mediaPlayer.Play();
        }

        /// <summary>
        /// Countdown befor a fight starts
        /// </summary>
        public void PlayCountDown()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\robotic-countdown.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 0.02;
            mediaPlayer.Play();
        }

        /// <summary>
        /// Intro to Wembley
        /// </summary>
        public void PlayWemblyIntro()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\Wembly Greetings.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 1;
            mediaPlayer.Play();
        }

        /// <summary>
        /// Intro to Backyard
        /// </summary>
        public void PlayBackyardIntro()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\Backyard Greetings.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 1;
            mediaPlayer.Play();
        }

        /// <summary>
        /// Intro to Bellagio
        /// </summary>
        public void PlayBellagioIntro()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\Bellagio Greetings.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 1;
            mediaPlayer.Play();
        }

        /// <summary>
        /// Sound during a fight 
        /// </summary>
        public void PlayFighting()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\PlayFighting.wav", UriKind.Relative);//Karate chops long
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 1;
            mediaPlayer.Play();
        }

              
        /// <summary>
        /// Plays the intro to Arena
        /// </summary>
        public void PlayArenaIntro()
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\PlayArenaIntro.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 1;
            
            mediaPlayer.Play();
        }

        /// <summary>
        /// Applauses during Arena presentations
        /// </summary>
        public void PlayArenaPresentationApplause() 
        {
            Uri uri = new Uri(@"C:\Users\Rocks\source\repos\sup21_g10b\supX\Resources\PlayArenaPresentationApplause.wav", UriKind.Relative);
            mediaPlayer.Open(uri);
            mediaPlayer.Volume = 0.2;
            mediaPlayer.Play();

        }


        #endregion


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
            var player = new SoundPlayer(Properties.Resources.Wembly_Greetings);
            player.Play();
        }

        /// <summary>
        /// Intro to Backyard
        /// </summary>
        public void PlayBackyardIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.Backyard_Greetings);
            player.Play();
        }

        /// <summary>
        /// Intro to Bellagio
        /// </summary>
        public void PlayBellagioIntroSound()
        {
            var player = new SoundPlayer(Properties.Resources.Bellagio_Greetings);
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

        public void PlayArenaIntroSound() 
        {
            var player = new SoundPlayer(Properties.Resources.crowd_cheering_12s);
            player.Play();
        }

        #endregion



    }
}
