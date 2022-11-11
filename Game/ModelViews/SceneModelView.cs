using Models;

namespace ModelViews
{
    public sealed class SceneModelView
    {
        public Scene Scene { get; private set; }


        public void SetScene(Scene scene)
        {
            Scene = scene;
        }
    }
}