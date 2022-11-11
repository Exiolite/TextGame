using ModelViews;

namespace Views.Commands
{
    public sealed class RespawnCommand : Command
    {
        protected override void Run(string value)
        {
            ModelView.PlayerModelView.Create(value);
            ModelView.PlayerModelView.Display();
            ModelView.SceneModelView.SetScene(null);
        }
    }
}
