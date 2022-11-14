using ExNoSQL;
using Models;

namespace ModelViews
{
    public sealed class DbViewModel
    {
        #region Properties

        public bool IsAutoSaveEnabled { get; set; }

        #endregion
        
        #region Methods

        #region Public

        public void Save()
        {
            Db<Mc>.Context.PlayerCharacter = MainViewModel.PlayerViewModel.PlayerCharacter;
            Db<Mc>.Context.Scene = MainViewModel.SceneViewModel.Scene;
            Db<Mc>.Context.PlayerExperience = MainViewModel.ExperienceViewModel.PlayerExperience;
            Db<Mc>.Context.KillHistoryCharacters = MainViewModel.KillHistoryViewModel.KillHistoryCharacters;
            Db<Mc>.Context.IsAutoClearEnabled = MainViewModel.CommandViewModel.IsAutoClearEnabled;
            Db<Mc>.Context.IsAutoSaveEnabled = IsAutoSaveEnabled;
            
            Db<Mc>.Export();
        }

        public void Load(string name)
        {
            Db<Mc>.CreateNewContext();
            Db<Mc>.Import(name);

            MainViewModel.PlayerViewModel.PlayerCharacter = Db<Mc>.Context.PlayerCharacter;
            MainViewModel.SceneViewModel.Scene = Db<Mc>.Context.Scene;
            MainViewModel.ExperienceViewModel.PlayerExperience = Db<Mc>.Context.PlayerExperience;
            MainViewModel.KillHistoryViewModel.KillHistoryCharacters = Db<Mc>.Context.KillHistoryCharacters;
            
            MainViewModel.CommandViewModel.IsAutoClearEnabled = Db<Mc>.Context.IsAutoClearEnabled;
            IsAutoSaveEnabled = Db<Mc>.Context.IsAutoSaveEnabled;

        }

        public void New(string name)
        {
            Db<Mc>.CreateNewContext(name);
            
            MainViewModel.ExperienceViewModel.PlayerExperience = new Experience();
        }
        
        #endregion

        #endregion
    }
}
