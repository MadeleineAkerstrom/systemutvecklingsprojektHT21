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

        FighterViewModel fighter;
        public double[] Odds { get; set; }
        public int[] FighterIds { get; set; }
        public FighterViewModel Fighter1 { get; set; }
        public FighterViewModel Fighter2 { get; set; }

        public BettingViewWembleyViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

            OpenFile();

            GenerateOddsModel generateOddsModel = new GenerateOddsModel();
            GenerateFightsModel generateFightsModel = new GenerateFightsModel();

            int[] fighterArray = generateFightsModel.GenerateFight(fighter.fighters);
            Odds = generateOddsModel.GenerateOdds(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            Fighter1 = fighter.fighters[fighterArray[0]];
            Fighter2 = fighter.fighters[fighterArray[1]];

            sounds.PlayWemblyIntro();
            //MessageBox.Show(Odds[0] + " " + Fighter1.Name + " vs " + Fighter2.Name + " " + Odds[1]);
        }

        public void OpenFile()
        {
            fighter = FileHandler.FileHandler.Open<FighterViewModel>("fighters.json");

        }

    }
}