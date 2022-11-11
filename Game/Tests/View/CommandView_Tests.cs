using NUnit.Framework;

namespace Tests.View
{
    [TestFixture]
    public sealed class CommandView_Tests : TestsBase
    {
        [Test]
        public void GET_Commands_FROM_Assembly()
        {
            Assert.True(Views.View.CommandView.Commands.Count > 0);
        }
    }
}
