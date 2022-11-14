using System;
using System.Collections.Generic;
using Views.CommandPlugins;
using Views.Commands;

namespace Views
{
    public abstract class Command
    {
        private List<Checker> _commandPlugins;


        public void TryExecute(string userInput)
        {
            AddCheckers();
            
            string[] split = userInput.ToLower().Split(' ');
            if (GetCommandName() != split[0]) return;

            if (_commandPlugins != null)
                foreach (Checker commandPlugin in _commandPlugins)
                    if (!commandPlugin.Check()) return;
                
            if (GetType() != typeof(AutoClearCommand))
                if (View.CommandView.UseAutoClear)
                    Console.Clear();

            if (split.Length > 1)
                if (int.TryParse(split[1], out int value))
                {
                    Run(value - 1);
                    return;
                }
                else
                {
                    Run(split[1]);
                    return;
                }

            Run();
        }

        protected virtual void AddCheckers()
        {
            return;
        }

        protected void AddChecker(Checker checker)
        {
            if (_commandPlugins == null) _commandPlugins = new List<Checker>();
            
            _commandPlugins.Add(checker);
        }

        public string GetCommandName()
        {
            return ToString()
                .ToLower()
                .Replace("views.commands.", "")
                .Replace("command", "");
        }

        protected virtual void Run()
        {
            return;
        }

        protected virtual void Run(int value)
        {
            return;
        }

        protected virtual void Run(string value)
        {
            return;
        }
    }
}
