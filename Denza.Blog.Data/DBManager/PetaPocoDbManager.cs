using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;
using System.Configuration;

namespace Denza.Blog.Data.DBManager
{
    public sealed class PetaPocoDbManager:IDisposable
    {
        private static PetaPocoDbManager _instance=null;
        private static readonly object SyncRoot = new Object();
        private readonly Database _petaPocoDb = new Database(ConfigurationManager.ConnectionStrings["Denza.Blog"].ConnectionString, "MySql.Data.MySqlClient");

        private PetaPocoDbManager()
        {
        }

        public static PetaPocoDbManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (_instance == null)
                              _instance = new PetaPocoDbManager();
                    }
                }
                return _instance;
            }
        }

        public Database GetDBConnection
        {
            get { return _petaPocoDb; }
        }

        public void Dispose()
        {
            _petaPocoDb.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
