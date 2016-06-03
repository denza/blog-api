using System;

namespace Denza.Blog.DatabaseDataProvider.Infrastructure
{
    public partial class NovoVrijemeDB : PetaPoco.Database
    {
        #region Fields

        [ThreadStatic]
        static NovoVrijemeDB _instance;

        #endregion

        #region Properties

        public static IFactory Factory { get; set; }

        #endregion

        #region Constructors

        public NovoVrijemeDB()
            : base("NovoVrijeme")
        {
            CommonConstruct();
        }

        public NovoVrijemeDB(string connectionStringName)
            : base(connectionStringName)
        {
            CommonConstruct();
        }

        partial void CommonConstruct();

        #endregion

        #region Interface

        public interface IFactory
        {
            NovoVrijemeDB GetInstance();
        }

        #endregion

        #region Methods

        public static NovoVrijemeDB GetInstance()
        {
            if (_instance != null)
                return _instance;

            if (Factory != null)
                return Factory.GetInstance();
            else
                return new NovoVrijemeDB();
        }

        public override void OnBeginTransaction()
        {
            if (_instance == null)
                _instance = this;
        }

        public override void OnEndTransaction()
        {
            if (_instance == this)
                _instance = null;
        }

        #endregion
    }
}
