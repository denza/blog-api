using PetaPoco;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denza.Blog.DatabaseDataProvider.Infrastructure
{
    public class PetaPocoDatabaseManager : IDisposable
    {
        #region Fields

        private static PetaPocoDatabaseManager _instance = null;
        private static readonly object SyncRoot = new Object();
        private readonly Database _petaPocoDatabase;

        #endregion

        #region Properties

        public static PetaPocoDatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                            _instance = new PetaPocoDatabaseManager();
                    }
                }
                return _instance;
            }
        }

        public Database GetConnection
        {
            get { return _petaPocoDatabase; }
        }

        #endregion

        #region Constructors

        private PetaPocoDatabaseManager()
        {
            _petaPocoDatabase = new Database(ConfigurationManager.ConnectionStrings["NovoVrijeme"].ConnectionString, "MySql.Data.MySqlClient");
        }

        #endregion    
    
        #region Methods

        public void Dispose()
        {
            _petaPocoDatabase.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
