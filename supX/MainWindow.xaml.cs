﻿using supX.Assets.Filehandler;
using supX.Commands;
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
            OpenFile();
            

        }

        public void SaveFile() 
        {
            FileHandler.Save(fighter, filename);
        
        
        }

        public void OpenFile() 
        {
            fighter = FileHandler.Open<FighterViewModel>("fighters.json");
            /*listFighter.ItemsSource = fighter.fighters;*/ //To see that the list is propely displayed
            
        }

        private void PlayerView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
