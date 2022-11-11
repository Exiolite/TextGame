using System;
using System.Collections.Generic;
using System.Linq;
using Views.Commands;

namespace Views
{
    public sealed class CommandView
    {
        public List<Command> Commands { get; } = new List<Command>();
        public bool UseAutoClear { get; set; } = false;
        public bool UseUpdate { get; private set; } = true;


        public CommandView()
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
                    command.Execute(userInput);
                }
            }

            Environment.Exit(0);
        }
    }
}
