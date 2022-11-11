using System.Collections.Generic;

namespace Models
{
    public class Scene
    {
        public List<Character> Enemies { get; }


        public Scene(List<Character> enemies)
        {
            Enemies = enemies;
        }


        public static Scene GetTestScene() => new Scene(
            new List<Character>()
            {
                new Character("Tugoserya", new Health(15), new Damage(10)),
                new Character("Foxiris", new Health(15), new Damage(10)),
                new Character("Harambe", new Health(15), new Damage(10)),
            }
        );
        
        public void Display()
        {
            if (Enemies == null) return;
            if (Enemies.Count == 0) return;

            foreach (Character character in Enemies)
            {
                character.Display();
            }
        }

        public bool TryGetEnemy(int index, out Character enemy)
        {
            if (Enemies.Count <= index)
            {
                enemy = null;
                return false;
            }

            enemy = Enemies[index];
            return true;
        }

        public void OnCharacterDeath(Character character)
        {
            if (Enemies.Contains(character))
                Enemies.Remove(character);
        }
    }
}
