using supX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace supX.ViewModels
{
    public class BettingViewWembleyViewModel : BaseViewModel
    {

        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();
        public MainViewModel Parent { get; }
        public GameViewModel GameVM { get; set; }

        public BettingViewWembleyViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;


            GameVM = new GameViewModel();

            OpenFile();

            GenerateOddsModel generateOddsModel = new GenerateOddsModel();
            GenerateFightsModel generateFightsModel = new GenerateFightsModel();

            int[] fighterArray = generateFightsModel.GenerateFight(fighter.fighters);
            Odds = generateOddsModel.GenerateOdds(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            Fighter1 = fighter.fighters[fighterArray[0]];
            Fighter2 = fighter.fighters[fighterArray[1]];

            sounds.PlayWemblyIntro();
            
        }

        public void OpenFile()
        {
            fighter = FileHandler.FileHandler.Open<FighterViewModel>("fighters.json");


        }

    }
}