using Denza.Blog.Api.Public;
using Denza.Blog.Api.Public.Entities;
using Denza.Blog.Api.Public.Infrastructure;
using Denza.Blog.CacheDataProvider.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denza.Blog.CacheDataProvider
{
    public class CacheProvider : IBlogApiDataProvider
    {
        #region Fields

        IBlogApiDataProvider _dataProvider;
        DataHelper _data;

        #endregion

        #region Properties

        public IBlogApiDataProvider DataProvider
        {
            get
            {
                return _dataProvider;
            }
        }

        protected DataHelper Data
        {
            get
            {
                return _data;
            }
        }

        #endregion

        #region Constructors

        public CacheProvider(IBlogApiDataProvider dataProvider)
        {
            _dataProvider = dataProvider;
            _data = new DataHelper(_dataProvider);
        }

        #endregion

        #region Methods

        public Post GetPostById(int postId)
        {
            return Data.Get<Post>().FirstOrDefault(post => post.PostId == (uint)postId);
        }

        public IQueryable<Post> GetPostByName(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetPostByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetPostsByCategory(string name, int page, int size)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetCategories(int page, int size)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetPostComment(int postId)
        {
            return Data.Get<Comment>().Where(comment => comment.PostId == postId);
        }

        public IQueryable<Category> GetCategories()
        {
            return Data.Get<Category>();
        }

        public IQueryable<Post> GetPosts()
        {
            return Data.Get<Post>();
        }

        public IQueryable<Comment> GetPostComment(int postId, int page, int size)
        {
            return Data.Get<Comment>().Where(x => x.PostId == postId).Skip(page * size).Take(page);
        }
        
        #endregion

        public IQueryable<Category> GetPopularCategories(int? categoryNumber, int? postNumber)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetCategories(int? page, int? size)
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryByName(string name)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Post> GetPostsByCategory(string name, int? page, int? size)
        {
            throw new NotImplementedException();
        }


        public IQueryable<Post> GetPosts(int? page = null, int? size = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> GetComments()
        {
            throw new NotImplementedException();
        }
    }
}
