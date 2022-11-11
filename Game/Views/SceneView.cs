using ModelViews;

namespace Views
{
    public sealed class SceneView
    {
        public SceneModelView SceneModelView { get; }


        public SceneView()
        {
            SceneModelView = new SceneModelView();
        }
    }
}
