using System;

namespace Views.Commands
{
    public class ClearCommand : Command
    {
        protected override void Run()
        {
            Console.Clear();
        }
    }
}
