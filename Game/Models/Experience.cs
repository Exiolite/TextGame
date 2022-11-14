namespace Models
{
    public sealed class Experience : Model
    {
        #region Properties

        public uint Level { get; set; } = 0;
        public uint Value { get; set; } = 0;
        public uint NextLevelValue { get; private set; } = 100;
        public float NextLevelMultiplier { get; } = 1.2f;

        #endregion


        #region Constructors

        public Experience()
        {
        }

        #endregion


        #region Methods
        
        #region Public
        
        public override string ToString() => Value.ToString();

        public void Add(uint experienceValue)
        {
            Value += experienceValue;

            TryAddLevel();
        }

        #endregion


        #region Private

        private void TryAddLevel()
        {
            if (Value < NextLevelValue) return;

            uint temp = NextLevelValue - Value;
            Level++;
            Value = temp;
            NextLevelValue *= (uint)NextLevelMultiplier;
        }

        #endregion

        #endregion
    }
}
