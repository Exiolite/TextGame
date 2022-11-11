using System;
using ExNoSQL;

namespace Models
{
    [Serializable]
    public class Mc : Context
    {
        public Character PlayerCharacter { get; set; }
        public Scene Scene { get; set; } 
        
        
        public Mc() : base("D:/TextGame.exdb")
        {
        }
    }
}
