namespace Views.Commands
{
    public sealed class LookCommand : Command
    {
        protected override void Run()
        {
            View.SceneView.SceneModelView.DisplayScene();
        }
    }
}
