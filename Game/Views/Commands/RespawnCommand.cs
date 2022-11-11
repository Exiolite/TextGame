using ModelViews;

namespace Views.Commands
{
    public sealed class RespawnCommand : Command
    {
        protected override void Run()
        {
            ModelView.PlayerModelView.Create();
            ModelView.PlayerModelView.Player.Display();
            ModelView.SceneModelView.SetScene(null);
        }
    }
}
