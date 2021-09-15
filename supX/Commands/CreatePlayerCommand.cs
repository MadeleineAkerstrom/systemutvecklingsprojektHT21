using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.Commands
{
    public class CreatePlayerCommand 

    {
       public PlayerViewModel CreatePlayer()
        {
            PlayerViewModel playerViewModel = new PlayerViewModel()
            { MyBalance = 100,
            MyName = "Madde"};
            return playerViewModel;
        }
        public CreatePlayerCommand()
        {
            
        }

    }
}

