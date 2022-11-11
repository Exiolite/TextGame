using ModelViews;

namespace Views
{
    public sealed class View
    {
        public static CommandView CommandView { get; private set; }
        

        public View()
        {
            ModelView modelView = new ModelView();
            
            CommandView = new CommandView();
        }
    }
}
