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

namespace supX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string filename = "fighters1.json";
        FighterViewModel fighters = new FighterViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            OpenFile();
           
        }

        public void SaveFile()
        {
            FileHandler.Save(fighters, filename);


        }

        public void OpenFile()
        {
            fighters = FileHandler.Open<FighterViewModel>("fighters1.json");
        }

        private void PlayerView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
