using Models;
using ModelViews;

namespace Views.Commands
{
    public sealed class AttackCommand : Command
    {
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
