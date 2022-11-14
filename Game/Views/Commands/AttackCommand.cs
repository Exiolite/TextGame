using Models.Entities;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class AttackCommand : Command
    {
        protected override void AddCheckers()
        {
            AddChecker(new ContextInitialized());
            AddChecker(new PlayerInitialized());
        }
        
        protected override void Run(int value)
        {
            if (MainViewModel.SceneViewModel.Scene.TryGetEnemyByIndex(value, out Character enemy))
            {
                MainViewModel.PlayerViewModel.Attack(enemy);
                MainViewModel.PlayerViewModel.Display();
                MainViewModel.SceneViewModel.Display();
            }
        }
    }
}
