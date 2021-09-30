namespace supX.ViewModels
{
    public class CashOutViewModel : BaseViewModel
    {

        #region Properties
        public MainViewModel Parent { get; }

        #endregion


        #region Constructor
        public CashOutViewModel(MainViewModel mainViewModel)
        {
            Parent = mainViewModel;

        }
        #endregion


    }
}
