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
            AddChecker(new ContextInitializedChecker());
            AddChecker(new PlayerAliveChecker());
        }

        protected override void Run(int value)
        {
            if (MainViewModel.SceneViewModel.Scene.TryGetEnemyByIndex(value, out Character enemy)) 
                MainViewModel.PlayerViewModel.Attack(enemy);
        }

        protected override void DisplayMessages()
        {
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
