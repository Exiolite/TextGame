using ExNoSQL;
using Models;
using ModelViews;

namespace Views.Commands
{
    public class GameLoadCommand : Command
    {
        protected override void Run()
        {
            Db<Mc>.Import();

            MainViewModel.PlayerViewModel.PlayerCharacter = Db<Mc>.Context.PlayerCharacter;
            MainViewModel.SceneViewModel.Scene = Db<Mc>.Context.Scene;
            MainViewModel.ExperienceViewModel.PlayerExperience = Db<Mc>.Context.PlayerExperience;
        }
    }
}
