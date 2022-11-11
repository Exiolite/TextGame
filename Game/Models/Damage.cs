namespace Models
{
    public sealed class Damage : Model
    {
        public int Value { get; }


        public Damage(int value)
        {
            Value = value;
        }
    }
}
