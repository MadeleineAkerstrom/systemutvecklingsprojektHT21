using supX.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Windows.Media;

namespace supX.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        
        //public PlayerViewModel Player { get; set; }

        private PlayerViewModel player;

        public PlayerViewModel Player
        {
            get { return player; }
            set { player = value; NotifyPropertyChanged(); }
        }


        private MainViewModel gameViewModel;

        public MainViewModel GameViewModel
        {
            get { return gameViewModel; }
            set 
            { gameViewModel = value;
                NotifyPropertyChanged();
            }
        }

        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set 
            { currentViewModel = value;
                NotifyPropertyChanged();
            }
        }

        public ICommand ChangeViewCommand { get; }

        public MainViewModel()
        {
            
            ChangeViewCommand = new ChangeViewCommand(this);
            currentViewModel = new StartViewModel(null);
            if (Player == null)
            {
                Player = new PlayerViewModel(this) { MyBalance = 100 };
            }
        }
    }
}
