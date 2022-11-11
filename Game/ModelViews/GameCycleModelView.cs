using Models;

namespace ModelViews
{
    public sealed class GameCycleModelView
    {
        public GameCycle GameCycle { get; }
        
        
        public GameCycleModelView()
        {
            GameCycle = new GameCycle();
        }
    }
}