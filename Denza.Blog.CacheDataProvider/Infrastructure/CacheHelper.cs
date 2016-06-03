
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;


namespace Denza.Blog.CacheDataProvider.Infrastructure
{
    public class CacheHelper
    {
        #region Fields

        //HttpContext.Currne _cache;
        private static CacheHelper _instance;
        static object _syncLock = new object();

        #endregion

        #region Properties

        public static CacheHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new CacheHelper();
                        }
                    }
                }

                return _instance;
            }
        }

        #endregion

        #region Constructors

        private CacheHelper()
        {

        }

        #endregion

        #region Methods

        public void Add(string key, object value, CacheItemRemovedCallback callback = null)
        {
            HttpRuntime.Cache.Add(key, value, null, DateTime.Now.AddHours(1), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.High, callback);
        }

        public T Get<T>(string key) where T : class
        {
            return HttpRuntime.Cache[key] as T;
        }

        public void Remove(string key)
        {
            HttpRuntime.Cache.Remove(key);
        }

        public T Remove<T>(string key) where T : class
        {
            var item = HttpRuntime.Cache.Get(key);
            HttpRuntime.Cache.Remove(key);
            return item as T;
        }

        #endregion
    }
}
