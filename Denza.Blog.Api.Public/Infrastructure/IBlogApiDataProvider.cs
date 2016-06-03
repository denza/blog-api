using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.Api.Public.Entities;

namespace Denza.Blog.Api.Public.Infrastructure
{
    public interface IBlogApiDataProvider
    {
        #region Popular

        IQueryable<Category> GetPopularCategories(int? categoryNumber = null, int? postNumber = null);

        #endregion

        #region Categories

        IQueryable<Category> GetCategories(int? page = null, int? size = null);

        Category GetCategoryByName(string name);

        #endregion

        #region Posts

        Post GetPostById(int postId);

        IQueryable<Post> GetPostByAuthor(string author);

        IQueryable<Post> GetPosts( int? page = null, int? size = null);

        IQueryable<Post> GetPostsByCategory(string name, int? page = null, int? size = null);

        #endregion

        #region Comments

        IQueryable<Comment> GetPostComment(int postId);

        IQueryable<Comment> GetComments();

        #endregion

    }
}
