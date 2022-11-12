using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class LookCommand : Command
    {
        protected override void AddCheckers()
        {
            AddCommandPlugin(new ContextInitialized());
            AddCommandPlugin(new PlayerInitialized());
        }
        
        protected override void Run()
        {
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
