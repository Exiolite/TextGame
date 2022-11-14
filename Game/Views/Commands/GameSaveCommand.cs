using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class GameSaveCommand : Command
    {
        protected override void AddCheckers()
        {
            AddChecker(new ContextInitialized());
            AddChecker(new PlayerInitialized());
        }

        protected override void Run()
        {
            MainViewModel.DbViewModel.Save();
        }
    }
}
