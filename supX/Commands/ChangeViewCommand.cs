using supX.Data;
using supX.ViewModels;
using supX.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.Commands
{
    public class ChangeViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel mainViewModel;

        public ChangeViewCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = this.mainViewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            GotoView view = (GotoView)parameter;

            switch(view)
            {
                case GotoView.GameView:
                    mainViewModel.CurrentViewModel = new ArenaViewModel();
                    break;
                case GotoView.PlayerView:
                    mainViewModel.CurrentViewModel = new PlayerViewModel();
                    break;
                default:
                    break;
            }

        }
    }
}
