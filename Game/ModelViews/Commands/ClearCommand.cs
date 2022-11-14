using System;

namespace ModelViews.Commands
{
    public class ClearCommand : Command
    {
        public override string GetDescription() =>
            $"{GetCommandName()}: clear console";
        
        protected override void Run()
        {
            Console.Clear();
        }
    }
}
