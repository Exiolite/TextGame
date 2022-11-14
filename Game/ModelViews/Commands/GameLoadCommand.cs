using ExNoSQL;
using Models;

namespace ModelViews.Commands
{
    public class GameLoadCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()} -saveName: load save by given name";
        
        protected override void Run(string value)
        {
            MainViewModel.DbViewModel.Load(value);
            
            
            MainViewModel.LocalizationViewModel.DisplayMessage(
                "Message.Game.Load",
                Db<Mc>.Context.Name
            );
        }
    }
}
