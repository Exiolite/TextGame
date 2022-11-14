using ModelViews;
using NUnit.Framework;

namespace Tests.ModelView
{
    [TestFixture]
    public class LocalizationViewModel_Tests : TestsBase
    {
        [Test]
        public void LocalizationDictionary_IS_NOT_COUNT_0()
        {
            Assert.True(MainViewModel.LocalizationViewModel.Localization.Count > 0);            
        }

        [Test]
        public void INVOKE_DisplayMessage()
        {
            MainViewModel.LocalizationViewModel.DisplayMessage("Player.Null");
        }
    }
}
