using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class CallThirdPartyEncodingService : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Calling third-party enconding service...");
            }
        }
    }
}
