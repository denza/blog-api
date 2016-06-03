using System.Collections;
using Denza.Blog.Api.Public;
using Denza.Blog.Api.Public.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Denza.Blog.DatabaseDataProvider.Models;
using Denza.Blog.DatabaseDataProvider.Infrastructure;
using Post = Denza.Blog.DatabaseDataProvider.Models.Post;

namespace Denza.Blog.DatabaseDataProvider
{
    public class DatabaseProvider : IBlogApiDataProvider
    {
        #region Popular

        public IQueryable<Api.Public.Entities.Category> GetPopularCategories(int? categoryNumber, int? postNumber)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Categories

        public IQueryable<Api.Public.Entities.Category> GetCategories(int? page, int? size)
        {
            return PetaPocoDatabaseManager.Instance.GetConnection.Query<Category>(
                    "SELECT * FROM wp_terms")
                    .Select(post => post.ToPublic()).AsQueryable<Api.Public.Entities.Category>();
        }

        public Api.Public.Entities.Category GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Posts

        public Api.Public.Entities.Post GetPostById(int postId)
        {
            return PetaPocoDatabaseManager.Instance.GetConnection.SingleOrDefault<Post>(
                    "SELECT * FROM wp_posts WHERE ID=@0", postId).ToPublic();
        }

        public IQueryable<Api.Public.Entities.Post> GetPostByAuthor(string author)
        {
            return PetaPocoDatabaseManager.Instance.GetConnection.Query<Post>(
                    "SELECT * FROM wp_posts WHERE post_author=@0", author)
                    .Select(post => post.ToPublic()).AsQueryable<Api.Public.Entities.Post>();
        }

        public IQueryable<Api.Public.Entities.Post> GetPostsByCategory(string name, int? page, int? size)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Api.Public.Entities.Post> GetPosts(int? page = null, int? size = null)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Comments

        public IQueryable<Api.Public.Entities.Comment> GetPostComment(int postId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Api.Public.Entities.Comment> GetComments()
        {
            throw new NotImplementedException();
        }

        #endregion

        //public IQueryable<Api.Public.Entities.Post> GetPostByName(string name)
        //{
        //    return PetaPocoDatabaseManager.Instance.GetConnection.Query<Post>(
        //            "SELECT * FROM wp_posts WHERE post_name=0", name)
        //            .Select(post => post.ToPublic()).AsQueryable<Api.Public.Entities.Post>();
        //}

        //public IQueryable<Api.Public.Entities.Post> GetPosts()
        //{
        //    return PetaPocoDatabaseManager.Instance.GetConnection.Query<Post>(
        //         "SELECT * FROM wp_posts").Select(post => post.ToPublic()).AsQueryable<Api.Public.Entities.Post>();
        //}
    }
}
