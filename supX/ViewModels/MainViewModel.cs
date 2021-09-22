using supX.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        //public PlayerViewModel MyPlayer { get; set; } //Might not need this one
        private MainViewModel balanceViewModel;

        public MainViewModel BalanceViewModel
        {
            get { return balanceViewModel; }
            set
            {
                balanceViewModel = value;
                NotifyPropertyChanged();
            }
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
        }
    }
}
