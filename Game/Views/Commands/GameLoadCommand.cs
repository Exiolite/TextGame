using ModelViews;

namespace Views.Commands
{
    public class GameLoadCommand : Command
    {
        protected override void Run(string value)
        {
            MainViewModel.DbViewModel.Load(value);
        }
    }
}
