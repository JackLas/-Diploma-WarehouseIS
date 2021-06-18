/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using System.Text.Json;

namespace Warehouse.Controllers.Admin
{
    public class AdminController : BaseController
    {
        private IAdminControllerListener m_listener;
        private Common.Types.Topology m_currentTopology;

        public AdminController(IAdminControllerListener listener) : base()
        {
            m_listener = listener;
            m_currentTopology = new Common.Types.Topology();
            m_db.subscribeOnReconnect(this.onReconnect);
        }

        public void onReconnect()
        {
            m_listener.handleNotification("Reconnect");
        }

        public void addEmployee(string name, int post, string address, string phone, string login)
        {
            if (m_db.isUsernameAlreadyExists(login))
            {
                m_listener.onLoginAlreadyExists();
                return;
            }

            m_db.addUser(login, post);
            Common.Types.Account acc = m_db.getUserAccountData(login);

            m_db.addEmployee(name, phone, address, acc.id);

            m_listener.onEmployeeAdded();
        }

        public void refreshEmployeeList(string search = "")
        {
            var list = m_db.getEmployees(search);
            m_listener.onEmployeeListUpdate(list);
        }

        public Common.Types.Employee getEmployeeByID(int id)
        {
            return m_db.getEmployeeByID(id);
        }

        public void addClient(string name, string address, string info)
        {
            m_db.addClient(name, address, info);
            m_listener.onClientAdded();
        }

        public void refreshClientList(string search = "")
        {
            var clientList = m_db.getClients(search);
            m_listener.onClientListRefresh(clientList);
        }

        public Common.Types.Client getClientByID(int id)
        {
            return m_db.getClientByID(id);
        }

        public void topologyAddRow()
        {
            m_currentTopology.increaseSizeY();
            m_listener.onCurrentTopologyUpdate(m_currentTopology);
        }

        public void topologyDeleteRow()
        {
            m_currentTopology.decreaseSizeY();
            m_listener.onCurrentTopologyUpdate(m_currentTopology);
        }

        public void topologyAddColumn()
        {
            m_currentTopology.increaseSizeX();
            m_listener.onCurrentTopologyUpdate(m_currentTopology);
        }

        public void topologyDeleteColumn()
        {
            m_currentTopology.decreaseSizeX();
            m_listener.onCurrentTopologyUpdate(m_currentTopology);
        }

        public void addNewShelf(string name, int length, int width, int height, int weight, int levels)
        {
            m_db.addNewShelf(name, length, width, height, weight, levels);
            m_listener.onNewShelfAdded();
        }

        public void refreshShelfList()
        {
            var list = m_db.getShelfList();
            m_listener.onShelfListRefresh(list);
        }

        public Common.Types.Shelf getShelfByID(int id)
        {
            return m_db.getShelfByID(id);
        }

        public void addShelfToTopology(int shelfID, int x, int y)
        {
            if (m_currentTopology.addShelf(shelfID, x, y))
            {
                m_listener.onCurrentTopologyUpdate(m_currentTopology);
            }
        }
        public void removeShelfFromTopology(int x, int y)
        {
            if (m_currentTopology.removeShelf(x, y))
            {
                m_listener.onCurrentTopologyUpdate(m_currentTopology);
            }
        }

        public void saveTopology(string name)
        {
            string json = JsonSerializer.Serialize(m_currentTopology);
            m_db.saveTopology(name, json);
            m_listener.onTopologySaved();
        }

        public void clearTopology()
        {
            m_currentTopology = new Common.Types.Topology();
        }
    }
}
