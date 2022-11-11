using ExNoSQL;
using Models;
using ModelViews;

namespace Views.Commands
{
    public sealed class GameSaveCommand : Command
    {
        protected override void Run()
        {
            Db<Mc>.Context.PlayerCharacter = MainViewModel.PlayerViewModel.PlayerCharacter;
            Db<Mc>.Context.Scene = MainViewModel.SceneViewModel.Scene;

            Db<Mc>.Export();
        }
    }
}
