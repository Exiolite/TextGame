namespace Views.Commands
{
    public sealed class ExitCommand : Command
    {
        protected override void Run()
        {
            View.CommandView.Break();
        }
    }
}
