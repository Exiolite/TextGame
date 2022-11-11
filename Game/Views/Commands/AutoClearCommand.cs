using System;

namespace Views.Commands
{
    public sealed class AutoClearCommand : Command
    {
        protected override void Run()
        {
            View.CommandView.UseAutoClear = !View.CommandView.UseAutoClear;
        }
    }
}
