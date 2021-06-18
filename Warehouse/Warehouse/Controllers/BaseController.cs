/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

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
