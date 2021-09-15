using supX.Assets.Filehandler;
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
        string filename = "fighters1.json";
        FighterViewModel fighters = new FighterViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            //createPlayerCommand.CreatePlayer();
            //CreatePlayerCommand createPlayerCommand = new CreatePlayerCommand();
            OpenFile();
            //SaveFile();

        }

        public void SaveFile() 
        {
            FileHandler.Save(fighters, filename);
        
        
        }

        public void OpenFile() 
        {
            fighters = FileHandler.Open<FighterViewModel>("fighters1.json");
            //More to come i guess
        }

        private void PlayerView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
