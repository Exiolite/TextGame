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
            IsTrue(new ContextInitialized());
            IsTrue(new PlayerAlive());
        }

        protected override void Run()
        {
            MainViewModel.DbViewModel.Save();
            
            
            MainViewModel.LocalizationViewModel.DisplayMessage(
                "Message.Game.Save",
                Db<Mc>.Context.Name
            );
        }
    }
}
