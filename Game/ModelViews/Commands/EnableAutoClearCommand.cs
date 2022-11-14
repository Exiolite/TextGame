namespace ModelViews.Commands
{
    public sealed class EnableAutoClearCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: clear console after every command";


        protected override void Run()
        {
            MainViewModel.CommandViewModel.IsAutoClearEnabled =
                !MainViewModel.CommandViewModel.IsAutoClearEnabled;
        }

        protected override void DisplayMessages()
        {
            MainViewModel.LocalizationViewModel.DisplayMessage(
                MainViewModel.CommandViewModel.IsAutoClearEnabled
                    ? "Message.Game.AutoClear.Enabled"
                    : "Message.Game.AutoClear.Disabled"
            );
        }
    }
}
