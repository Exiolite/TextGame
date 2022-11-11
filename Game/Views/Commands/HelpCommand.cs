using System;

namespace Views.Commands
{
    public sealed class HelpCommand : Command
    {
        protected override void Run()
        {
            Console.WriteLine("Commands: ");

            foreach (Command command in View.CommandView.Commands)
            {
                Console.WriteLine($"    {command.GetCommandName()}");
            }
        }
    }
}
