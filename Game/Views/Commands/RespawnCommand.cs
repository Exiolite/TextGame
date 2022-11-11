using Models;
using ModelViews;

namespace Views.Commands
{
    public sealed class RespawnCommand : Command
    {
        protected override void Run(string value)
        {
            MainViewModel.PlayerViewModel.PlayerCharacter = CharacterFactory.Normal(value);
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
        }
    }
}
