using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Denza.Blog.Domain.DTO
{
    [DataContract]
    public class Post
    {
        [DataMember]
        public ulong ID { get; set; }
        [DataMember]
        public ulong Author { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public DateTime DateGmt { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Excerpt { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string CommentStatus { get; set; }
        [DataMember]
        public string PingStatus { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Ping { get; set; }
        [DataMember]
        public string Pinged { get; set; }
        [DataMember]
        public DateTime DateModified { get; set; }
        [DataMember]
        public DateTime DateModifiedGmt { get; set; }
        [DataMember]
        public string PostContentFiltered { get; set; }
        [DataMember]
        public ulong PostParent { get; set; }
        [DataMember]
        public string Guid { get; set; }
        [DataMember]
        public int MenuOrder { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string MimeType { get; set; }
        [DataMember]
        public long CommentCount { get; set; }
    }
}
