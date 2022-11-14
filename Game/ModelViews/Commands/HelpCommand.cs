using System;

namespace ModelViews.Commands
{
    public sealed class HelpCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: display all commands";
        
        protected override void DisplayMessages()
        {
            Console.WriteLine("Commands: ");

            foreach (Command command in MainViewModel.CommandViewModel.Commands)
            {
                Console.WriteLine($"    {command.GetDescription()}");
            }
        }
    }
}
