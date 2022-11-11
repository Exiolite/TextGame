using ModelViews;

namespace Views
{
    public sealed class View
    {
        public static CommandView CommandView { get; private set; }

        
        public View()
        {
            CommandView = new CommandView();
            ModelView modelView = new ModelView();
            
            CommandView.ReadUserCommands();
        }
    }
}
