using System;
using Models;

namespace ModelViews
{
    public sealed class PlayerViewModel
    {
        public Character PlayerCharacter { get; set; } = new Character();
        

        public PlayerViewModel Display()
        {
            if (PlayerCharacter == null)
                MainViewModel.LocalizationViewModel.DisplayMessage("Player.Null");
            else
                Console.WriteLine($"{PlayerCharacter}");
            
            return this;
        }

        public PlayerViewModel Attack(Character character)
        {
            if (character == null)
            {
                MainViewModel.LocalizationViewModel.DisplayMessage("Scene.Enemies.Null");
                return this;
            }

            if (PlayerCharacter == null)
            {
                MainViewModel.LocalizationViewModel.DisplayMessage("Player.Null");
                return this;
            }

            Console.WriteLine(!character.Health.TryApplyDamage(PlayerCharacter.Damage)
                ? $"{character.Name} was killed by {PlayerCharacter.Name}"
                : $"{PlayerCharacter.Name} caused {PlayerCharacter.Damage} damage to {character.Name}");

            if (!PlayerCharacter.Health.TryApplyDamage(character.Damage))
                MainViewModel.LocalizationViewModel.DisplayMessage("Player.Dead");

            return this;
        }
    }
}
