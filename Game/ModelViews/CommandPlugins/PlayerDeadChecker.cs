namespace ModelViews.CommandPlugins
{
    public sealed class PlayerDeadChecker : Checker
    {
        public override bool Check()
        {
            bool flag = MainViewModel.PlayerViewModel.PlayerCharacter.Health.Value > 0;

            if (!flag)
                MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player.Dead");
            
            return flag;
        }
    }
}
