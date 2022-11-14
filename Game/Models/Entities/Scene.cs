using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public sealed class Scene : ExNoSQL.Entity
    {
        public List<Character> Enemies { get; set; }


        public static Scene GetTestScene() => new Scene()
        {
            Enemies = new List<Character>()
            {
                CharacterFactory.Custom("Tugoserya", 15, 10),
                CharacterFactory.Custom("Foxiris", 15, 10),
                CharacterFactory.Custom("Harambe", 15, 10),
            }
        };

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (Enemies is { Count: 0 }) return "There is no one";

            stringBuilder.AppendLine("You see: ");
            foreach (Character character in Enemies)
            {
                stringBuilder.AppendLine($"     {Enemies.IndexOf(character) + 1} - {character.FightName}");
            }

            return stringBuilder.ToString();
        }

        public bool TryGetEnemyByIndex(int index, out Character enemy)
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
