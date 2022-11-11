using Models;
using ModelViews;

namespace Views.Commands
{
    public sealed class HuntCommand : Command
    {
        protected override void Run()
        {
            ModelView.SceneModelView.SetScene(Scene.GetTestScene());
            ModelView.PlayerModelView.Player.Display();
            ModelView.SceneModelView.Scene.Display();
        }
    }
}
