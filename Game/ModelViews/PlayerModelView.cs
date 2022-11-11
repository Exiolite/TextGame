using System;
using Models;

namespace ModelViews
{
    public sealed class PlayerModelView
    {
        public Character Player { get; private set; }


        public PlayerModelView()
        {
            Create();
        }
        

        public void Create()
        {
            Player = new Character(
                "Player",
                new Health(100),
                new Damage(12)
            );
        }

        public void Attack(Character character)
        {
            if (character == null)
            {
                Console.WriteLine("There is no one to attack");
                return;
            }

            if (Player == null)
            {
                Console.WriteLine("Dead can not attack");
                return;
            }

            if (!character.Health.TryApplyDamage(Player.Damage))
            {
                Console.WriteLine($"{character.Name} is dead");
                ModelView.SceneModelView.Scene.OnCharacterDeath(character);
            }

            if (!Player.Health.TryApplyDamage(character.Damage))
                Console.WriteLine($"{Player.Name} is dead");
        }
    }
}
