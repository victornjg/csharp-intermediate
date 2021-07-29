using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class UploadVideo : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Uploading video to the cloud storage...");
            }
        }
    }
}
