using Models;
using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class RespawnCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: respawn player";
        
        protected override void InitializeCheckers()
        {
            AddChecker(new ContextInitializedChecker());
            AddChecker(new PlayerNotAliveChecker());
        }

        protected override void Run(string value)
        {
            if (value.ToLower().Contains(nameof(CharacterFactory.Easy).ToLower()))
                MainViewModel.PlayerViewModel.PlayerCharacter = CharacterFactory.Easy(value);

            if (value.ToLower().Contains(nameof(CharacterFactory.Normal).ToLower()))
                MainViewModel.PlayerViewModel.PlayerCharacter = CharacterFactory.Normal(value);

            if (value.ToLower().Contains(nameof(CharacterFactory.Hard).ToLower()))
                MainViewModel.PlayerViewModel.PlayerCharacter = CharacterFactory.Hard(value);
        }

        protected override void DisplayMessages()
        {
            MainViewModel.PlayerViewModel.Display();
        }
    }
}
