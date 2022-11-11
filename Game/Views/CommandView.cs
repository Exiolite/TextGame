using System;
using System.Collections.Generic;
using System.Linq;
using Views.Commands;

namespace Views
{
    public sealed class CommandView
    {
        public List<Command> Commands { get; } = new List<Command>();


        public CommandView()
        {
            foreach (Type type in GetType().Assembly.GetTypes()
                         .Where(o => o.BaseType == typeof(Command)))
                Commands.Add((Command)Activator.CreateInstance(type));
        }

        public void ReadUserCommands()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                foreach (Command command in Commands)
                {
                    command.Run(userInput);
                }
            }
        }
    }
}
