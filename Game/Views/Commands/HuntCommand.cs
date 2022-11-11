using Models;

namespace Views.Commands
{
    public sealed class HuntCommand : Command
    {
        protected override void Run()
        {
            View.SceneView.SceneModelView.SetScene(Scene.GetTestScene());
            View.SceneView.SceneModelView.DisplayScene();
        }
    }
}
