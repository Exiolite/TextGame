using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class EnableAutoSaveCommand : Command
    {
        protected override void AddCheckers()
        {
            AddChecker(new ContextInitialized());
        }

        protected override void Run()
        {
            
        }
    }
}
