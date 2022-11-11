using System;
using System.ComponentModel.Design;
using Models;

namespace ModelViews
{
    public sealed class PlayerModelView
    {
        public Character Player { get; private set; }


        public void Create(string name)
        {
            Player = new Character(
                name,
                new Health(100),
                new Damage(12)
            );
        }

        public void Display()
        {
            if (Player == null)
                ModelView.LocalizationModelView.DisplayMessage("Player.Null");
            else
                Console.WriteLine($"{Player}");
        }

        public void Attack(Character character)
        {
            if (character == null)
            {
                ModelView.LocalizationModelView.DisplayMessage("Scene.Enemies.Null");
                return;
            }

            if (Player == null)
            {
                ModelView.LocalizationModelView.DisplayMessage("Player.Null");
                return;
            }

            Console.WriteLine(!character.Health.TryApplyDamage(Player.Damage)
                ? $"{character.Name} was killed by {Player.Name}"
                : $"{Player.Name} caused {Player.Damage} damage to {character.Name}");

            if (!Player.Health.TryApplyDamage(character.Damage))
                ModelView.LocalizationModelView.DisplayMessage("Player.Dead");
        }
    }
}
