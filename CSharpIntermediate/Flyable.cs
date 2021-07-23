using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class Flyable
        {
            public double MaxHeight { get; set; }

            public void Fly()
            {
                Console.WriteLine("Flying... The maximum height that I can reach is " + this.MaxHeight);
            }
        }
    }
}
