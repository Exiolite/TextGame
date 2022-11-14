using ModelViews;
using NUnit.Framework;

namespace Tests.View
{
    [TestFixture]
    public sealed class CommandView_Tests : TestsBase
    {
        [Test]
        public void GET_Commands_FROM_Assembly()
        {
            var l = MainViewModel.CommandViewModel.Commands;
            Assert.True(l.Count > 0);
        }
    }
}
