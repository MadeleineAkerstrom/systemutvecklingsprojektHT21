using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        public MainViewModel Parent { get;}

        public StartViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
