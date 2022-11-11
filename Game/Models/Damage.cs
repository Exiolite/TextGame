namespace Models
{
    public sealed class Damage : Model
    {
        public int Value { get; set; }

        public Damage()
        {
            
        }

        public Damage(int value)
        {
            Value = value;
        }
        
        public override string ToString() => Value.ToString();
    }
}
