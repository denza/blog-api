using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoVrijeme.Api.Public.Infrastructure
{
    public interface INovoVrijemeApiDataProvider
    {
        Post GetPostById(int postId);

        IEnumerable<Post> GetPostsByCategory(string name, int page, int size);

        IEnumerable<Category> GetCategories(int page, int size);

        IEnumerable<Comment> GetPostComment(int postId);

    }
}
