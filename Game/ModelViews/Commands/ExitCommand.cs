namespace ModelViews.Commands
{
    public sealed class ExitCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: exit from game";
        
        protected override void Run()
        {
            MainViewModel.CommandViewModel.Break();
        }
    }
}
