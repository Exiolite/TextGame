using ExNoSQL;
using Models;
using ModelViews;

namespace Views
{
    public sealed class View
    {
        public static CommandView CommandView { get; private set; }
        public static LocalizationViewModel LocalizationViewModel { get; private set; }


        public View()
        {
            CommandView = new CommandView();
            LocalizationViewModel = new LocalizationViewModel();

            MainViewModel mainViewModel = new MainViewModel();
        }
    }
}
