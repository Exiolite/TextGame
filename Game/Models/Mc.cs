using System;
using ExNoSQL;

namespace Models
{
    [Serializable]
    public class Mc : Context
    {
        public Character PlayerCharacter { get; set; }
        public Scene Scene { get; set; }
        
        public Repository<Character> KilledCharactersByPlayer { get; set; } = new Repository<Character>();


        public Mc() : base("D:/TextGame.exdb")
        {
        }
    }
}
