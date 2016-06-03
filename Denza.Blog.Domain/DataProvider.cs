using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.Data;
using Denza.Blog.Domain.DTO;
using Denza.Blog.Domain.Helper;

namespace Denza.Blog.Domain
{
    public class DataProvider:IDataProvider
    {
        readonly IRepository _repository=new Repository();

        public List<Post> PetaPocoGetPosts()
        {
            var petaPocoGetPosts = _repository.PetaPocoGetPosts();
            var posts = Mapper.MapPosts(petaPocoGetPosts);
            return posts;
        }

        public IEnumerable<dynamic> DapperGetPosts()
        {
            return _repository.DapperGetPosts();
        }
    }
}
