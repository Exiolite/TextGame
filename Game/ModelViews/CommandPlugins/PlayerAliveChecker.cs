namespace ModelViews.CommandPlugins
{
    public sealed class PlayerAliveChecker : Checker
    {
        public override bool Check()
        {
            bool flag = MainViewModel.PlayerViewModel.PlayerCharacter != null;

            if (!flag)
                MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player.Null");
            
            return flag;
        }
    }
}
