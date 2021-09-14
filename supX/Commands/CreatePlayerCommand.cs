using supX.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace supX.Commands
{
    public class CreatePlayerCommand 

    {
       public Player CreatePlayer()
        {
            Player player = new Player()
            { MyBalance = 100,
            MyName = "Madde"};
            return player;
        }
        public CreatePlayerCommand()
        {
            
        }

    }
}

