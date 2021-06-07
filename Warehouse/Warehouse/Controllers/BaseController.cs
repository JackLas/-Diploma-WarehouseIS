using Common.Interfaces;

namespace Warehouse.Controllers
{
    public class BaseController : System.IDisposable
    {
        protected IDBProvider m_db;

        public BaseController()
        {
            m_db = Model.DBProviderFactory.createProvider();
            m_db.open();
        }

        public void Dispose()
        {
            m_db.close();
        }
    }
}
