using Models;
using ModelViews;

namespace Views.Commands
{
    public sealed class HuntCommand : Command
    {
        protected override void Run()
        {
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
