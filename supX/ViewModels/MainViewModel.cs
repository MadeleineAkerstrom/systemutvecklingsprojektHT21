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

        //public BaseViewModel BottomViewModel { get; set; } = new PlayerViewModel();

        
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
