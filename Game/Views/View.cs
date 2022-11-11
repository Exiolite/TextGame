using ModelViews;

namespace Views
{
    public sealed class View
    {
        public static CommandView CommandView { get; private set; }
        public static LocalizationModelView LocalizationModelView { get; private set; }


        public View()
        {
            CommandView = new CommandView();
            LocalizationModelView = new LocalizationModelView();

            ModelView modelView = new ModelView();
        }
    }
}
