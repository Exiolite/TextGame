using ExNoSQL;
using Models;

namespace ModelViews.Commands
{
    public sealed class GameNewCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()} -characterName/saveName: start new game with given character/save name";

        protected override void Run()
        {
            MainViewModel.LocalizationViewModel.DisplayMessage(
                "Message.Command.BadParameters",
                GetDescription()
            );
        }

        protected override void Run(string value)
        {
            MainViewModel.DbViewModel.New(value);
            

            MainViewModel.LocalizationViewModel.DisplayMessage(
                "Message.Game.New",
                Db<Mc>.Context.Name
            );
            MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player");
        }
    }
}
