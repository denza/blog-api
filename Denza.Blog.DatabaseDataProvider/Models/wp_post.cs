using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoVrijeme.DatabaseDataProvider.Models
{
    [TableName("wp_posts")]
    [PrimaryKey("ID")]
    [ExplicitColumns]
    public partial class wpPost
    {
        [Column]
        public ulong ID { get; set; }
        [Column]
        public ulong post_author { get; set; }
        [Column]
        public DateTime post_date { get; set; }

        [Column]
        public DateTime post_date_gmt { get; set; }

        [Column]
        public string post_content { get; set; }

        [Column]
        public string post_title { get; set; }

        [Column]
        public string post_excerpt { get; set; }

        [Column]
        public string post_status { get; set; }

        [Column]
        public string comment_status { get; set; }

        [Column]
        public string ping_status { get; set; }

        [Column]
        public string post_password { get; set; }

        [Column]
        public string post_name { get; set; }

        [Column]
        public string to_ping { get; set; }

        [Column]
        public string pinged { get; set; }

        [Column]
        public DateTime post_modified { get; set; }

        [Column]
        public DateTime post_modified_gmt { get; set; }

        [Column]
        public string post_content_filtered { get; set; }

        [Column]
        public ulong post_parent { get; set; }

        [Column]
        public string guid { get; set; }

        [Column]
        public int menu_order { get; set; }

        [Column]
        public string post_type { get; set; }

        [Column]
        public string post_mime_type { get; set; }

        [Column]
        public long comment_count { get; set; }
    }
}
