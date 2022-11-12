using Models;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class HuntCommand : Command
    {
        protected override void AddCheckers()
        {
            AddCommandPlugin(new ContextInitialized());
            AddCommandPlugin(new PlayerInitialized());
        }

        protected override void Run()
        {
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
