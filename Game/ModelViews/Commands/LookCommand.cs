using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class LookCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: display current scene";
        
        protected override void InitializeCheckers()
        {
            IsTrue(new ContextInitialized());
            IsTrue(new PlayerAlive());
        }

        protected override void Run()
        {
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
