using Denza.Blog.Api.Public.Entities;
using Denza.Blog.Api.Public.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;

namespace Denza.Blog.CacheDataProvider.Infrastructure
{
    public class DataHelper
    {
        #region Fields

        IBlogApiDataProvider _dataProvider;
        Dictionary<Type, Func<IBlogApiDataProvider, IQueryable>> _getters;

        #endregion

        #region Constructors

        public DataHelper(IBlogApiDataProvider dataProvider)
        {
            _dataProvider = dataProvider;

            _getters = new Dictionary<Type, Func<IBlogApiDataProvider, IQueryable>>()
            {
                 {typeof(Category),( provider) => {return provider.GetCategories();}},
                 {typeof(Post),( provider) => {return provider.GetPosts();}},
                 {typeof(Comment),( provider) => {return provider.GetComments();}},
            };
        }

        #endregion

        #region Methods

        public IQueryable<T> Get<T>()
        {
            var type = typeof(T);
            return  (IQueryable<T>)LoadCollection(type);
        }      

        protected void OnRemoveCallback(string key, object value, CacheItemRemovedReason reason)
        {
            Type type = _getters.Keys.First(x => x.Name == key);
            LoadCollection(type);
        }

        private IQueryable LoadCollection(Type type)
        {            
            var result = CacheHelper.Instance.Get<IQueryable>(type.Name);

            if (result == null)
            {
                result =_getters[type](_dataProvider);
                CacheHelper.Instance.Add(type.Name, result, OnRemoveCallback);
            }

            return result;

        }

        #endregion
    }
}
