using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class InstructionsViewModel : BaseViewModel
    {
        public MainViewModel Parent { get; }
        public InstructionsViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
    }
}
