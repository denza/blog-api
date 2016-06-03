using System;

namespace Denza.Blog.Api.Public.Entities
{
    public class Post
    {
        public ulong PostId { get; set; }

        public string Author { get; set; }        

        public string Content { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public DateTime DateGmt { get; set; }

    }
}
