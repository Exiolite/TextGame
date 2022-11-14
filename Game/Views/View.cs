using ExNoSQL;
using Models;
using ModelViews;

namespace Views
{
    public sealed class View
    {



        public View()
        {
            CommandView = new CommandView();
            LocalizationViewModel = new LocalizationViewModel();

            MainViewModel mainViewModel = new MainViewModel();
        }
    }
}
