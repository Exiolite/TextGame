using ModelViews;

namespace Application
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainViewModel mainViewModel = new MainViewModel();
            MainViewModel.CommandViewModel.ReadUserCommands();
        }
    }
}
