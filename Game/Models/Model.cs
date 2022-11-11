using System;

namespace Models
{
    public abstract class Model
    {
        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
