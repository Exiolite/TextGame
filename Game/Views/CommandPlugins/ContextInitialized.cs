using ExNoSQL;
using Models;
using ModelViews;

namespace Views.CommandPlugins
{
    public sealed class ContextInitialized : Checker
    {
        public override bool Check()
        {
            bool flag = Db<Mc>.Context != null;
            
            if (!flag)
                MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Db.Context");
            
            return flag;
        }
    }
}
