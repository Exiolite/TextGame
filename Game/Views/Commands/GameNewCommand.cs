using ModelViews;

namespace Views.Commands
{
    public sealed class GameNewCommand : Command
    {
        protected override void Run(string value)
        {
            MainViewModel.DbViewModel.New(value);
        }
    }
}
