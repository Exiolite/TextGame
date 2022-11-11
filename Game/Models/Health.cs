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
            if (Value <= damage.Value) return false;
            
            Value -= damage.Value;
            return true;
        }


        public override string ToString() => Value.ToString();
    }
}
