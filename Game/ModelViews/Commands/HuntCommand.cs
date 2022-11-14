using Models.Entities;
using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class HuntCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: hunt for enemies";
        
        protected override void InitializeCheckers()
        {
            AddChecker(new ContextInitializedChecker());
            AddChecker(new PlayerAliveChecker());
        }

        protected override void Run()
        {
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
        }

        protected override void DisplayMessages()
        {
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
