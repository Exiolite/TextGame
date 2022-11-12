using System;
using System.Collections.Generic;
using ExNoSQL;
using Models;

namespace ModelViews
{
    public sealed class PlayerViewModel
    {
        public Character PlayerCharacter { get; set; }

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

            if (!character.Health.TryApplyDamage(PlayerCharacter.Damage))
            {
                Console.WriteLine($"{character.Name} was killed by {PlayerCharacter.Name}");
                Db<Mc>.Context.KilledCharactersByPlayer.Insert(character);
            }
            else
            {
                Console.WriteLine($"{PlayerCharacter.Name} caused {PlayerCharacter.Damage} damage to {character.Name}");
            }


            if (!PlayerCharacter.Health.TryApplyDamage(character.Damage))
                MainViewModel.LocalizationViewModel.DisplayMessage("Player.Dead");

            return this;
        }
    }
}
