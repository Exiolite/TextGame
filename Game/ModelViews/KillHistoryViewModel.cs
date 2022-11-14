using System.Collections.Generic;
using Models.Entities;

namespace ModelViews
{
    public sealed class KillHistoryViewModel
    {
        #region Properties

        public List<Character> KillHistoryCharacters { get; set; } = new List<Character>();

        #endregion


        #region Methods

        #region Public

        public void AddCharacterToKillFeed(Character character)
        {
            KillHistoryCharacters.Add(character);
        }

        #endregion

        #endregion
    }
}
