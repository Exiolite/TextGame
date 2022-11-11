using ModelViews;

namespace Views.Commands
{
    public sealed class LookCommand : Command
    {
        protected override void Run()
        {
            MainViewModel.PlayerViewModel.Display();
            MainViewModel.SceneViewModel.Display();
        }
    }
}
