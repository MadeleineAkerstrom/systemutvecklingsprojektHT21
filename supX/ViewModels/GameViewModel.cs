using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using supX.Models;


namespace supX.ViewModels
{
    public class GameViewModel : BaseViewModel
    {
        string filename = new Uri(@".\Assets\Json\fighters.json", UriKind.Relative).ToString();
        public FighterViewModel fighter;
        public double[] Odds { get; set; }
        public int[] FighterIds { get; set; }
        public FighterViewModel Fighter1 { get; set; }
        public FighterViewModel Fighter2 { get; set; }
        public MainViewModel Parent { get; }

        public GameViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
            
        }

        public GameViewModel()
        {
            OpenFile();
            GenerateArena();
        }

        public void GenerateArena()
        {

            GenerateOddsModel generateOddsModel = new GenerateOddsModel();
            GenerateFightsModel generateFightsModel = new GenerateFightsModel();

            int[] fighterArray = generateFightsModel.GenerateFight(fighter.fighters);
            Odds = generateOddsModel.GenerateOdds(fighter.fighters[fighterArray[0]], fighter.fighters[fighterArray[1]]);
            Fighter1 = fighter.fighters[fighterArray[0]];
            Fighter2 = fighter.fighters[fighterArray[1]];
        }

        public void OpenFile()
        {
            fighter = FileHandler.FileHandler.Open<FighterViewModel>(filename);
        }
    }
}
