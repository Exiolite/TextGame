namespace ModelViews.CommandPlugins
{
    public sealed class PlayerAlive : Checker
    {
        public override bool Check()
        {
            bool flag = MainViewModel.PlayerViewModel.PlayerCharacter != null &&
                        MainViewModel.PlayerViewModel.PlayerCharacter.Health.Value > 0;

            if (!flag)
                MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player.Null");
            
            return flag;
        }
    }
}
