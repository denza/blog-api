using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denza.Blog.Data
{
    public interface IRepository
    {
        //PetaPoco
        IEnumerable<wpPost> PetaPocoGetPosts();

        //Dapper
        IEnumerable<dynamic> DapperGetPosts();

    }
}
