using System;
using System.Collections.Generic;
using ExNoSQL;
using Models.Entities;

namespace Models
{
    [Serializable]
    public class Mc : Context
    {
        public Character PlayerCharacter { get; set; }
        public Experience PlayerExperience { get; set; }
        public Scene Scene { get; set; }
        
        public List<Character> KillHistoryCharacters { get; set; }


        public bool IsAutoClearEnabled { get; set; }
        public bool IsAutoSaveEnabled { get; set; }
        
        public Mc() : base("D:/")
        {
        }
    }
}
