using System;
using Models.Entities;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public class KillHistoryCommand : Command
    {
        protected override void AddCheckers()
        {
            AddChecker(new ContextInitialized());
            AddChecker(new PlayerInitialized());
        }

        protected override void Run()
        {
            foreach (Character character in MainViewModel.KillHistoryViewModel.KillHistoryCharacters)
                Console.WriteLine(character);
        }
    }
}
