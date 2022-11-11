namespace Views
{
    public sealed class View
    {
        public static SceneView SceneView { get; private set; }
        public static CommandView CommandView { get; private set; }
        
        public View()
        {
            SceneView = new SceneView();
            CommandView = new CommandView();
            
            CommandView.ReadUserCommands();
        }
    }
}
