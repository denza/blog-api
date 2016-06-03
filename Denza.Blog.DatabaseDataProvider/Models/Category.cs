using Denza.Blog.DatabaseDataProvider.Infrastructure;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denza.Blog.DatabaseDataProvider.Models
{
    [TableName("wp_terms")]
    [PrimaryKey("ID")]
    [ExplicitColumns]
    public class Category : Record<Post>
    {
        [Column("term_id")]
        public ulong CategoryId { get; set; }

         [Column("name")]
        public string Name { get; set; }
    }
}
