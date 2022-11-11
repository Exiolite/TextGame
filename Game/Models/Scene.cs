using System.Collections.Generic;
using System.Text;

namespace Models
{
    public sealed class Scene : Model
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

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (Enemies is { Count: 0 }) return "There is no one";

            foreach (Character character in Enemies)
            {
                stringBuilder.AppendLine(character.ToString());
            }

            return stringBuilder.ToString();
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
