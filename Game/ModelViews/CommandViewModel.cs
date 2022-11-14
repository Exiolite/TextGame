using System;
using System.Collections.Generic;
using System.Linq;

namespace ModelViews
{
    public sealed class CommandViewModel
    {
        public List<Command> Commands { get; } = new List<Command>();
        public bool IsAutoClearEnabled { get; set; } = false;
        public bool UseUpdate { get; private set; } = true;


        public CommandViewModel()
        {
            foreach (Type type in GetType().Assembly.GetTypes()
                         .Where(o => o.BaseType == typeof(Command)))
                Commands.Add((Command)Activator.CreateInstance(type));
        }


        public void Break()
        {
            UseUpdate = false;
        }


        public void ReadUserCommands()
        {
            while (UseUpdate)
            {
                Console.Write("Command: ");
                string userInput = Console.ReadLine();
                foreach (Command command in Commands)
                {
                    command.TryExecute(userInput);
                }
            }

            Environment.Exit(0);
        }
    }
}
