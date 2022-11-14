using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class LookCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: display current scene";
        
        protected override void InitializeCheckers()
        {
            AddChecker(new ContextInitializedChecker());
            AddChecker(new PlayerAliveChecker());
        }
        
        protected override void DisplayMessages()
        {
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
