namespace Models
{
    public static class CharacterFactory
    {
        public static Character Weak(string name) => new Character()
        {
            Name = name,
            Health = new Health(80),
            Damage = new Damage(10)
        };

        public static Character Normal(string name) => new Character()
        {
            Name = name,
            Health = new Health(100),
            Damage = new Damage(20)
        };

        
        public static Character Strong(string name) => new Character()
        {
            Name = name,
            Health = new Health(120),
            Damage = new Damage(30)
        };
        
        public static Character Custom(string Name, int health, int damage) => new Character()
        {
            Name = Name,
            Health = new Health(health),
            Damage = new Damage(damage)
        };
        
        public static Character EnemySlime => new Character()
        {
            Name = "Slime",
            Health = new Health(15),
            Damage = new Damage(20)
        };
    }
}
