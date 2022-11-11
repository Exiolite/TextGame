namespace Models
{
    public sealed class GameCycle : Model
    {
        public bool Update { get; private set; }

        
        public void Break()
        {
            Update = false;
        }
    }
}