using System;
using System.Collections.Generic;
using System.Text;

namespace supX.ViewModels
{
    public class CashOutViewModel : BaseViewModel
    {
        PlayerViewModel player /*= new PlayerViewModel()*/;
        #region Properties
        public MainViewModel Parent { get; }
        #endregion


        #region Constructor
        public CashOutViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;
        }
        #endregion

        public PlayerViewModel SavePlayerName(PlayerViewModel player) 
        {
            player.MyName;
            player.MyBalance;
            player.player.Add(player);
            return player;
        }
        private void UpdateList() 
        {
            
        
        }

    }
}
