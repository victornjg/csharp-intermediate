using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class SendEmail : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Sending email to the owner of the video notifying them that the video started processing...");
            }
        }
    }
}
