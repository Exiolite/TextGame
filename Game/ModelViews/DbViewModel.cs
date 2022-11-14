using ExNoSQL;
using Models;

namespace ModelViews
{
    public sealed class DbViewModel
    {
        #region Methods

        #region Public

        public void Save()
        {
            Db<Mc>.Context.PlayerCharacter = MainViewModel.PlayerViewModel.PlayerCharacter;
            Db<Mc>.Context.Scene = MainViewModel.SceneViewModel.Scene;
            Db<Mc>.Context.PlayerExperience = MainViewModel.ExperienceViewModel.PlayerExperience;
            Db<Mc>.Context.KillHistoryCharacters = MainViewModel.KillHistoryViewModel.KillHistoryCharacters;
            
            Db<Mc>.Export();
            
            MainViewModel.LocalizationViewModel.DisplayMessage("Message.Game.Save");
        }

        public void Load(string name)
        {
            Db<Mc>.CreateNewContext();
            Db<Mc>.Import(name);

            MainViewModel.PlayerViewModel.PlayerCharacter = Db<Mc>.Context.PlayerCharacter;
            MainViewModel.SceneViewModel.Scene = Db<Mc>.Context.Scene;
            MainViewModel.ExperienceViewModel.PlayerExperience = Db<Mc>.Context.PlayerExperience;
            MainViewModel.KillHistoryViewModel.KillHistoryCharacters = Db<Mc>.Context.KillHistoryCharacters;
            
            MainViewModel.LocalizationViewModel.DisplayMessage("Message.Game.Load", name);
        }

        public void New(string name)
        {
            Db<Mc>.CreateNewContext(name);
            
            MainViewModel.LocalizationViewModel.DisplayMessage("Message.Game.New", name);
            MainViewModel.LocalizationViewModel.DisplayMessage("Checker.Player");
            MainViewModel.ExperienceViewModel.PlayerExperience = new Experience();
        }
        
        #endregion

        #endregion
    }
}
