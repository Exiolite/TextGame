using Addons;

namespace Views.Commands
{
    public abstract class Command
    {
        public void Run(string userInput)
        {
            userInput = userInput.Replace(" ", "").ToLower();

            if (!GetCommandName().Contains(userInput)) return;

            Run();
        }

        public string GetCommandName()
        {
            return ToString()
                .ToLower()
                .Replace("views.commands.", "")
                .Replace("command", "");
        }
        
        protected abstract void Run();
    }
}
