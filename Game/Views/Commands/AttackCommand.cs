using Models;
using ModelViews;
using Views.CommandPlugins;

namespace Views.Commands
{
    public sealed class AttackCommand : Command
    {
        protected override void AddCheckers()
        {
            AddCommandPlugin(new ContextInitialized());
            AddCommandPlugin(new PlayerInitialized());
        }
        
        protected override void Run(int value)
        {
            if (MainViewModel.SceneViewModel.Scene.TryGetEnemy(value, out Character enemy))
            {
                MainViewModel.PlayerViewModel.Attack(enemy);
                MainViewModel.PlayerViewModel.Display();
                MainViewModel.SceneViewModel.Display();
            }
        }
    }
}
