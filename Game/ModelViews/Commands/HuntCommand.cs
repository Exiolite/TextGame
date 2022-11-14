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
            IsTrue(new ContextInitialized());
            IsTrue(new PlayerAlive());
        }

        protected override void Run()
        {
            MainViewModel.SceneViewModel.Scene = Scene.GetTestScene();
            
            
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
