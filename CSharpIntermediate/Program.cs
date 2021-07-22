using System;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 2
            Post post = new Post("My question", "This is a description");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();

            Console.WriteLine("Votes: " + post.GetVotes());
        }
    }
}
