using ModelViews.CommandPlugins;

namespace ModelViews.Commands
{
    public sealed class EnableAutoSaveCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: save after every command";
        
        protected override void InitializeCheckers()
        {
            IsTrue(new ContextInitialized());
        }

        protected override void Run()
        {
            MainViewModel.DbViewModel.IsAutoSaveEnabled =
                !MainViewModel.DbViewModel.IsAutoSaveEnabled;
            
            
            MainViewModel.LocalizationViewModel.DisplayMessage(
                MainViewModel.DbViewModel.IsAutoSaveEnabled
                    ? "Message.Game.AutoSave.Enabled"
                    : "Message.Game.AutoSave.Disabled"
            );
        }
    }
}
