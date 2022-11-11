namespace Views.Commands
{
    public abstract class Command
    {
        public void Run(string userInput)
        {
            string[] split = userInput.ToLower().Split(' ');

            if (!GetCommandName().Contains(split[0])) return;

            if (split.Length > 1)
                if (int.TryParse(split[1], out int value))
                {
                    Run(value-1);
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
    }
}
