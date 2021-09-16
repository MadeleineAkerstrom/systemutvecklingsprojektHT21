using supX.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
     
        public CreatePlayerCommand createPlayerCommand = new CreatePlayerCommand();
        
        public PlayerViewModel myPlayer { get; set; }

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
            {
                currentViewModel = value;
                NotifyPropertyChanged();
            }
        } //Bort slut här

        public ICommand ChangeViewCommand { get; }

        public MainViewModel()
        {
            ChangeViewCommand = new ChangeViewCommand(this);
        }





    }
}
