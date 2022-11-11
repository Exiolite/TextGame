namespace Models
{
    public sealed class Character : ExNoSQL.Entity
    {
        public string Name { get; set; }
        public Health Health { get; set; }
        public Damage Damage { get; set; }

        public override string ToString()
        {
            return Health.Value <= 0
                ? $"Dead body of {Name}"
                : $"{Name} ({Health.Value}/{Health.MaxValue})[{Damage.Value}]";
        }
    }
}
