namespace ModelViews
{
    public sealed class ModelView
    {
        public static PlayerModelView PlayerModelView { get; private set; }
        public static SceneModelView SceneModelView { get; private set; }


        public ModelView()
        {
            PlayerModelView = new PlayerModelView();
            SceneModelView = new SceneModelView();
        }
    }
}
