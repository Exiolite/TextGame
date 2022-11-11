using System.Threading.Tasks;
using NUnit.Framework;
using Views;

namespace Tests.ModelView
{
    [TestFixture]
    public sealed class CommandModelView_Tests : TestsBase
    {
        [Test]
        public async Task GET_Commands_FROM_Assembly()
        {
            Assert.True(View.CommandView.Commands.Count > 0);
        }
    }
}
