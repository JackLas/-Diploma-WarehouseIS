namespace Warehouse.Controllers.Admin
{
    class AdminController : BaseController
    {
        private IAdminControllerListener m_listener;
        private Common.Types.Topology m_currentTopology;

        public AdminController(IAdminControllerListener listener) : base()
        {
            m_listener = listener;
            m_currentTopology = new Common.Types.Topology();
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
    }
}
