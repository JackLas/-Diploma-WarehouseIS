using System.Text.Json;

namespace Warehouse.Controllers.General
{
    class GeneralController : BaseController
    {
        private IGeneralControllerListener m_listener;
        private int m_currentUserID;
        private int m_currentUserAccess;
        private Common.Types.Topology m_currentTopology;

        public GeneralController(IGeneralControllerListener listener, int userID, int userLevel) : base()
        {
            m_listener = listener;
            m_currentUserID = userID;
            m_currentUserAccess = userLevel;

            m_listener.onAccessLevelUpdate((Common.Types.Posts)m_currentUserAccess);
        }

        public void loadWarehouseTopology(int id)
        {
            string json = m_db.getTopologyByID(id);
            m_currentTopology = JsonSerializer.Deserialize<Common.Types.Topology>(json);
            m_listener.onCurrentTopologyUpdate(m_currentTopology);
        }

        public void refreshWarehouseList()
        {
            var list = m_db.getRoomsIdentificatorList();
            m_listener.onWarehouseListUpdate(list);
        }
    }
}
