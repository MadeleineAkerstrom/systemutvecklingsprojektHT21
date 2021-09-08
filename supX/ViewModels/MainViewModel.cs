using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel { get; set; } = new ArenaViewModel();

        public BaseViewModel BottomViewModel { get; set; } = new PlayerViewModel();

        public ICommand ChangeViewCommand { get; }

    }
}
