using System;

namespace CSharpIntermediate
{
    partial class Program
    {
        public class UpdateVideoRecordOnDatabase : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Changing the status of the video record in the database to \"Processing\"...");
            }
        }
    }
}
