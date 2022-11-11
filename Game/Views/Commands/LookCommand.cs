using ModelViews;

namespace Views.Commands
{
    public sealed class LookCommand : Command
    {
        protected override void Run()
        {
            ModelView.PlayerModelView.Player?.Display();
            ModelView.SceneModelView.Scene?.Display();
        }
    }
}
