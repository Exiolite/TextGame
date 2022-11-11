using System;

namespace Addons
{
    public static class Logger
    {
        public static void Debug(object obj)
        {
            Console.WriteLine($"DEBUG: {obj}");
        }
    }
}