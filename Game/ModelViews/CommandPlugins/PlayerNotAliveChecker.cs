namespace ModelViews.CommandPlugins
{
    public sealed class PlayerNotAliveChecker : Checker
    {
        public override bool Check()
        {
            bool flag = MainViewModel.PlayerViewModel.PlayerCharacter == null;

            if (flag)
                MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player.Null");
            
            return flag;
        }
    }
}
