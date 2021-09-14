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
            this.mainViewModel = mainViewModel;
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
                case GotoView.ArenaView:
                    mainViewModel.CurrentViewModel = new ArenaViewModel();
                    break;
                case GotoView.PlayerView:
                    mainViewModel.CurrentViewModel = new PlayerViewModel();
                    break;
                case GotoView.GameView:
                    mainViewModel.CurrentViewModel = new GameViewModel();
                    break;
                case GotoView.RulesView:
                    mainViewModel.CurrentViewModel = new RulesViewModel();
                    break;
                case GotoView.WinnerView:
                    mainViewModel.CurrentViewModel = new WinnerViewModel();
                    break;
                case GotoView.LoserView:
                    mainViewModel.CurrentViewModel = new LoserViewModel();
                    break;
                default:
                    break;
            }

        }
    }
}
