using System;
using ExNoSQL;
using Models;

namespace Views.Commands
{
    public class KillHistoryCommand : Command
    {
        protected override void Run()
        {
            foreach (Character character in Db<Mc>.Context.KilledCharactersByPlayer.GetAll())
            {
                Console.WriteLine(character);
            }
        }
    }
}
