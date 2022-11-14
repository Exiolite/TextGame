using System;
using ExNoSQL;
using Models;

namespace ModelViews
{
    public sealed class PlayerViewModel
    {
        #region Properties

        public Character PlayerCharacter { get; set; }
        public Character CurrentEnemyCharacter { get; set; }

        #endregion


        #region Methods

        #region Public

        public void Display()
        {
            if (PlayerCharacter == null)
                MainViewModel.LocalizationViewModel.DisplayMessage("Player.Null");
            else
                Console.WriteLine($"{PlayerCharacter}<{MainViewModel.ExperienceViewModel.PlayerExperience}>");
        }

        public void Attack(Character character)
        {
            CurrentEnemyCharacter = character;

            CheckEnemyCharacter();
            CheckPlayerCharacter();
            ProcessPlayerAttack();
            ProcessEnemyAttack();
        }

        #endregion

        #region Private

        private void CheckEnemyCharacter()
        {
            if (CurrentEnemyCharacter == null)
            {
                MainViewModel.LocalizationViewModel.DisplayMessage("Scene.Enemies.Null");
                return;
            }

            if (CurrentEnemyCharacter.Health.Value < 0) return;
        }

        private void CheckPlayerCharacter()
        {
        }

        private void ProcessPlayerAttack()
        {
            if (!CurrentEnemyCharacter.Health.TryApplyDamage(PlayerCharacter.Damage))
            {
                Console.WriteLine($"{CurrentEnemyCharacter.Name} was killed by {PlayerCharacter.Name}");
                MainViewModel.ExperienceViewModel.PlayerExperience?.Add((uint)CurrentEnemyCharacter.Damage.Value);

                Db<Mc>.Context.KilledCharactersByPlayer.Insert(CurrentEnemyCharacter);
            }
            else
                Console.WriteLine(
                    $"{PlayerCharacter.Name} caused {PlayerCharacter.Damage} damage to {CurrentEnemyCharacter.Name}"
                );
        }

        private void ProcessEnemyAttack()
        {
            if (!PlayerCharacter.Health.TryApplyDamage(CurrentEnemyCharacter.Damage))
                MainViewModel.LocalizationViewModel.DisplayMessage("Player.Dead");
        }

        #endregion

        #endregion
    }
}
