using ModelViews;

namespace Views.CommandPlugins
{
    public sealed class PlayerInitialized : Checker
    {
        public override bool Check()
        {
            bool flag = MainViewModel.PlayerViewModel.PlayerCharacter != null;

            if (!flag)
                MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player");
            
            return flag;
        }
    }
}
