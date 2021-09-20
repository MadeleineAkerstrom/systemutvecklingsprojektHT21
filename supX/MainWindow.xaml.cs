﻿using supX.Commands;
using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using supX.Assets.Filehandler;
using supX.Models;
using System.Media;

namespace supX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string filename = "fighters.json";
        FighterViewModel fighter;
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            PlaySound();
            OpenFile();

            GenerateOddsModel generateOddsModel = new GenerateOddsModel();
            GenerateResultsModel generateResultsModel = new GenerateResultsModel();
            GenerateFightsModel generateFightsModel = new GenerateFightsModel();
            GenerateNewBalanceModel generateNewBalanceModel = new GenerateNewBalanceModel();

            int[] fighterArray = generateFightsModel.GenerateFight(fighter.fighters);
            double[] odds = generateOddsModel.GenerateOdds(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            FighterViewModel winner = generateResultsModel.GenerateResult(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            
            
        }

        public void OpenFile() 
        {
            fighter = FileHandler.FileHandler.Open<FighterViewModel>("fighters.json");
            
        }

        public void SaveFile() 
        {
            FileHandler.FileHandler.Save(fighter, filename);
        }

        public void PlaySound() 
        {
            var player = new SoundPlayer(Properties.ResourceRagnaros.By_fire_be_purged);
            player.Play();
        }

    }


}
