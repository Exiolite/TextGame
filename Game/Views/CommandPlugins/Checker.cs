namespace Views.CommandPlugins
{
    public abstract class Checker
    {
        public virtual bool Check()
        {
            return false;
        }
    }
}
