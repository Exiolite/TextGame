using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using ModelViews.CommandPlugins;
using ModelViews.Commands;

namespace ModelViews
{
    public abstract class Command
    {
        private List<Checker> _commandPlugins;


        public void TryExecute(string userInput)
        {
            string[] split = userInput.ToLower().Split(' ');
            if (GetCommandName() != split[0]) return;
            
            if (GetType() != typeof(EnableAutoClearCommand))
                if (MainViewModel.CommandViewModel.IsAutoClearEnabled)
                    Console.Clear();
            
            InitializeCheckers();

            if (_commandPlugins != null)
                foreach (Checker commandPlugin in _commandPlugins)
                    if (!commandPlugin.Check())
                        return;

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

            if (MainViewModel.DbViewModel.IsAutoSaveEnabled)
                MainViewModel.DbViewModel.Save();
        }

        public abstract string GetDescription();

        protected virtual void InitializeCheckers()
        {
            return;
        }

        protected void IsTrue(Checker checker)
        {
            if (_commandPlugins == null) _commandPlugins = new List<Checker>();

            _commandPlugins.Add(checker);
        }

        public string GetCommandName()
        {
            return ToString()
                .ToLower()
                .Replace("modelviews.commands.", "")
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
