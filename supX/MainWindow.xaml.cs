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
        string filename = "/Assets/Json/fighters.json";
        FighterViewModel fighter;
        Sounds.SoundsAndMusic sounds = new Sounds.SoundsAndMusic();       


        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            sounds.PlayIntroSound();            
        }



        public void SaveFile() 
        {
            FileHandler.FileHandler.Save(fighter, filename);
        }

              

    }


}
