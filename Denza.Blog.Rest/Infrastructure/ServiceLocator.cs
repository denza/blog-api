using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Denza.Blog.Rest.Infrastructure
{
    public sealed class ServiceLocator
    {
        #region Fields

        private readonly UnityContainer _container;
        private static readonly object SyncRoot = new Object();
        private static ServiceLocator _instance;

        #endregion

        #region Constructors

        private ServiceLocator()
        {
            try
            {
                _container = new UnityContainer();
                var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                section.Configure(_container);
            }
            catch (Exception ex)
            {              
                throw ex;
            }
            
        }

        #endregion

        #region Properties

        public static ServiceLocator Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new ServiceLocator();
                    }
                }
                return _instance;
            }
        }

        #endregion

        #region Methods

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public T Resolve<T>(string name)
        {
            return _container.Resolve<T>(name);
        }

        #endregion
    }
}