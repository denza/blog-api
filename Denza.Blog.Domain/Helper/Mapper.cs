using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.Domain.DTO;

namespace Denza.Blog.Domain.Helper
{
    public class Mapper
    {
        public static List<Post> MapPosts(IEnumerable<wpPost> wpPosts)
        {
            return wpPosts.Select(p => new Post
                                           {
                                               Author = p.post_author,
                                               CommentCount = p.comment_count,
                                               CommentStatus = p.comment_status,
                                               Content = p.post_content,
                                               Date = p.post_date,
                                               DateGmt = p.post_date_gmt,
                                               DateModified = p.post_modified,
                                               DateModifiedGmt = p.post_modified_gmt,
                                               Excerpt = p.post_excerpt,
                                               Guid = p.guid,
                                               ID = p.ID,
                                               MenuOrder = p.menu_order,
                                               MimeType = p.post_mime_type,
                                               Name = p.post_name,
                                               Password = p.post_password,
                                               Ping = p.to_ping,
                                               PingStatus = p.ping_status,
                                               Pinged = p.pinged,
                                               PostContentFiltered = p.post_content_filtered,
                                               PostParent = p.post_parent,
                                               Status = p.post_status,
                                               Title = p.post_title,
                                               Type = p.post_type
                                           }).ToList();
        }
    }
}
