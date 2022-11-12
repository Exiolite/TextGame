using System;
using ExNoSQL;
using Models;
using Views.CommandPlugins;

namespace Views.Commands
{
    public class KillHistoryCommand : Command
    {
        protected override void AddCheckers()
        {
            AddCommandPlugin(new ContextInitialized());
            AddCommandPlugin(new PlayerInitialized());
        }

        protected override void Run()
        {
            foreach (Character character in Db<Mc>.Context.KilledCharactersByPlayer.GetAll())
                Console.WriteLine(character);
        }
    }
}
