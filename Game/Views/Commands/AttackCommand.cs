using Models;
using ModelViews;

namespace Views.Commands
{
    public sealed class AttackCommand : Command
    {
        protected override void Run(int value)
        {
            if (ModelView.SceneModelView.Scene.TryGetEnemy(value, out Character enemy))
            {
                ModelView.PlayerModelView.Attack(enemy);
                ModelView.PlayerModelView.Player.Display();
                ModelView.SceneModelView.Scene.Display();
            }
        }
    }
}
