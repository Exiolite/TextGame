namespace Models
{
    public sealed class Health : Model
    {
        public int MaxValue { get; set; }
        public int Value { get; set; }

        public Health()
        {
            
        }

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
