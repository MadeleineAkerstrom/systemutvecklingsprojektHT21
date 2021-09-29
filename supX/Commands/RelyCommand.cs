using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.Commands
{
    class RelyCommand : ICommand
    {
        private Action action;

        public RelyCommand(Action action)
        {
            this.action = action;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            action();
        }
    }
}
