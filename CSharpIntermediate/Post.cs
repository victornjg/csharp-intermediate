using System;

namespace CSharpIntermediate
{
    public class Post
    {
        private string Title;
        private string Description;
        private DateTime CreationDate = DateTime.Now;
        private int Votes;

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public void UpVote()
        {
            this.Votes++;
        }

        public void DownVote()
        {
            this.Votes--;
        }

        public int GetVotes()
        {
            return this.Votes;
        }
    }
}
