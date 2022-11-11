using NUnit.Framework;

namespace Tests.View
{
    [TestFixture]
    public class LocalizationView_Tests : TestsBase
    {
        [Test]
        public void Localization_IS_COUNT_GREATER_THAN_0()
        {
            Assert.True(Views.View.LocalizationModelView.Localization.Count > 0);            
        }
    }
}
