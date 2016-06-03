using System;
using PetaPoco;
using Denza.Blog.DatabaseDataProvider.Infrastructure;

namespace Denza.Blog.DatabaseDataProvider.Models
{
    [TableName("wp_posts")]
    [PrimaryKey("ID")]
    [ExplicitColumns]
    public class Post : Record<Post>
    {
        [Column("ID")]
        public ulong ID { get; set; }

        [Column("post_author")]
        public string Author { get; set; }

        [Column("post_date_gmt")]
        public DateTime DateGmt { get; set; }

        [Column("post_content")]
        public string Content { get; set; }

        [Column("post_title")]
        public string Title { get; set; }
    }
}
