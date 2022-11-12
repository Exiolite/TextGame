using Models;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class RespawnCommand : Command
    {
        protected override void AddCheckers()
        {
            AddCommandPlugin(new ContextInitialized());
        }
        

        protected override void Run(string value)
        {
            MainViewModel.PlayerViewModel.PlayerCharacter = CharacterFactory.Normal(value);
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
        }
    }
}
