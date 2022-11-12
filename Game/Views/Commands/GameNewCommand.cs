using ExNoSQL;
using Models;
using ModelViews;
 
namespace Views.Commands
{
    public sealed class GameNewCommand : Command
    {
        protected override void Run()
        {
            Db<Mc>.CreateNewContext();
            
            MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player");
        }
    }
}
