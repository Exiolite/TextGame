using ExNoSQL;
using Models;

namespace ModelViews.CommandPlugins
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
