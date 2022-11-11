using ExNoSQL;
using Models;

namespace Views.Commands
{
    public sealed class GameNewCommand : Command
    {
        protected override void Run()
        {
            Db<Mc>.NewContext();
        }
    }
}
