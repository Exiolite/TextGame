using Models;
using Models.Entities;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class HuntCommand : Command
    {
        protected override void AddCheckers()
        {
            AddChecker(new ContextInitialized());
            AddChecker(new PlayerInitialized());
        }

        protected override void Run()
        {
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
