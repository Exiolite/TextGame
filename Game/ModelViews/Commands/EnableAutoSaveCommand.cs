using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class EnableAutoSaveCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: save after every command";
        
        protected override void InitializeCheckers()
        {
            AddChecker(new ContextInitializedChecker());
        }

        protected override void Run()
        {
            MainViewModel.DbViewModel.IsAutoSaveEnabled =
                !MainViewModel.DbViewModel.IsAutoSaveEnabled;
        }

        protected override void DisplayMessages()
        {
            MainViewModel.LocalizationViewModel.DisplayMessage(
                MainViewModel.DbViewModel.IsAutoSaveEnabled
                    ? "Message.Game.AutoSave.Enabled"
                    : "Message.Game.AutoSave.Disabled"
            );
        }
    }
}
