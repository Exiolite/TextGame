namespace Models.Entities
{
    public sealed class Character : ExNoSQL.Entity
    {
        public string FightName => Health.Value <= 0
            ? $"Dead body of {Name}"
            : $"{Name} ({Health.Value}/{Health.MaxValue})[{Damage.Value}]";
        
        public string Name { get; set; }
        public Health Health { get; set; }
        public Damage Damage { get; set; }
    }
}
