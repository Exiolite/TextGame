namespace ModelViews
{
    public sealed class MainViewModel
    {
        public static PlayerViewModel PlayerViewModel { get; private set; }
        public static SceneViewModel SceneViewModel { get; private set; }
        public static LocalizationViewModel LocalizationViewModel { get; private set; }
        public static ExperienceViewModel ExperienceViewModel { get; private set; }
        public static KillHistoryViewModel KillHistoryViewModel { get; private set; }
        public static DbViewModel DbViewModel { get; private set; }
        
        public MainViewModel()
        {
            PlayerViewModel = new PlayerViewModel();
            SceneViewModel = new SceneViewModel();
            LocalizationViewModel = new LocalizationViewModel();
            ExperienceViewModel = new ExperienceViewModel();
            KillHistoryViewModel = new KillHistoryViewModel();
            DbViewModel = new DbViewModel();
        }
    }
}
