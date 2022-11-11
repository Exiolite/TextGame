namespace Models
{
    public sealed class Health : Model
    {
        public int MaxValue { get; }
        public int Value { get; private set; }


        public Health(int value)
        {
            Value = value;
            MaxValue = value;
        }


        public bool TryApplyDamage(Damage damage)
        {
            Value -= damage.Value;
            
            return Value > 0;
        }


        public override string ToString() => Value.ToString();
    }
}
