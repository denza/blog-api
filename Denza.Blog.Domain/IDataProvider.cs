using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.Domain.DTO;

namespace Denza.Blog.Domain
{
    public interface IDataProvider
    {
        List<Post> PetaPocoGetPosts();

        IEnumerable<dynamic> DapperGetPosts();
    }
}
