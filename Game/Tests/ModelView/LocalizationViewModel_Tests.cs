using NUnit.Framework;

namespace Tests.ModelView
{
    [TestFixture]
    public class LocalizationViewModel_Tests : TestsBase
    {
        [Test]
        public void LocalizationDictionary_IS_NOT_COUNT_0()
        {
            Assert.True(Views.View.LocalizationViewModel.Localization.Count > 0);            
        }

        [Test]
        public void INVOKE_DisplayMessage()
        {
            Views.View.LocalizationViewModel.DisplayMessage("Player.Null");
        }
    }
}
