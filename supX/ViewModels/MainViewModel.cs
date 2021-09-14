using supX.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        //public BaseViewModel CurrentViewModel { get; set; } = new ArenaViewModel();

        //public BaseViewModel BalanceViewModel { get; set; } = new Player();

        public CreatePlayerCommand createPlayerCommand = new CreatePlayerCommand();
        //public string MyName { get; set; } = "Madde";
        //public double MyBalance { get; set; }

        private MainViewModel currentViewModel;

        public MainViewModel CurrentViewModel
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
