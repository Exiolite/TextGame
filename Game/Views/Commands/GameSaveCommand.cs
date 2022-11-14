using ExNoSQL;
using Models;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class GameSaveCommand : Command
    {
        protected override void AddCheckers()
        {
            AddCommandPlugin(new ContextInitialized());
            AddCommandPlugin(new PlayerInitialized());
        }
        
        protected override void Run()
        {
            Db<Mc>.Context.PlayerCharacter = MainViewModel.PlayerViewModel.PlayerCharacter;
            Db<Mc>.Context.Scene = MainViewModel.SceneViewModel.Scene;
            Db<Mc>.Context.PlayerExperience = MainViewModel.ExperienceViewModel.PlayerExperience;
            
            Db<Mc>.Export();
        }
    }
}
