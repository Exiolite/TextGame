using ExNoSQL;
using Models;
using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class RespawnCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()} -easy/normal/hard: respawn player with given difficulty";

        protected override void InitializeCheckers()
        {
            IsTrue(new ContextInitialized());
            IsTrue(new PlayerNotAlive());
        }

        protected override void Run()
        {
            MainViewModel.LocalizationViewModel.DisplayMessage(
                "Message.Command.BadParameters",
                GetDescription()
            );
        }

        protected override void Run(string value)
        {
            MainViewModel.SceneViewModel.Scene = null;
            
            if (value.ToLower().Contains(nameof(CharacterFactory.Easy).ToLower()))
                MainViewModel.PlayerViewModel.PlayerCharacter =
                    CharacterFactory.Easy(Db<Mc>.Context.Name);

            if (value.ToLower().Contains(nameof(CharacterFactory.Normal).ToLower()))
                MainViewModel.PlayerViewModel.PlayerCharacter =
                    CharacterFactory.Normal(Db<Mc>.Context.Name);

            if (value.ToLower().Contains(nameof(CharacterFactory.Hard).ToLower()))
                MainViewModel.PlayerViewModel.PlayerCharacter =
                    CharacterFactory.Hard(Db<Mc>.Context.Name);


            MainViewModel.PlayerViewModel.Display();
        }
    }
}
