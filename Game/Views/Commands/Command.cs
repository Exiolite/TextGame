using System;

namespace Views.Commands
{
    public abstract class Command
    {
        public void TryExecute(string userInput)
        {
            string[] split = userInput.ToLower().Split(' ');
            if (GetCommandName() != split[0]) return;
            
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
