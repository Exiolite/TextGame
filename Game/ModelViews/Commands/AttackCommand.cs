using Models.Entities;
using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class AttackCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()} -index: attack enemy with index";

        protected override void InitializeCheckers()
        {
            IsTrue(new ContextInitialized());
            IsTrue(new PlayerAlive());
        }

        protected override void Run(int value)
        {
            if (MainViewModel.SceneViewModel.Scene.TryGetEnemyByIndex(value, out Character enemy)) 
                MainViewModel.PlayerViewModel.Attack(enemy);
            
            
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
