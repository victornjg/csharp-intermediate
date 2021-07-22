using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stopwatch.Stop();

            Console.WriteLine("Duration: " + stopwatch.CalculateDuration());
        }
    }
}
