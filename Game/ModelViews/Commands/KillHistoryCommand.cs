using System;
using Models.Entities;
using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public class KillHistoryCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: display kill history";
        
        protected override void InitializeCheckers()
        {
            AddChecker(new ContextInitializedChecker());
        }

        protected override void DisplayMessages()
        {
            foreach (Character character in MainViewModel.KillHistoryViewModel.KillHistoryCharacters)
                Console.WriteLine(character);
        }
    }
}
