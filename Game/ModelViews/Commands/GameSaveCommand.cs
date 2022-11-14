using ExNoSQL;
using Models;
using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class GameSaveCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: save game progress to file";
        
        protected override void InitializeCheckers()
        {
            AddChecker(new ContextInitializedChecker());
            AddChecker(new PlayerAliveChecker());
        }

        protected override void Run()
        {
            MainViewModel.DbViewModel.Save();
        }
        
        protected override void DisplayMessages()
        {
            MainViewModel.LocalizationViewModel.DisplayMessage(
                "Message.Game.Save",
                Db<Mc>.Context.Name
            );
        }
    }
}
