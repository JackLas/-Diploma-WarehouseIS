using Common.Types;
using System.Collections.Generic;
using System.Text.Json;

namespace Warehouse.Controllers.General
{
    public class GeneralController : BaseController, IOrderController
    {
        private IGeneralControllerListener m_listener;
        private int m_currentUserID;
        private int m_currentUserAccess;
        private Topology m_currentTopology;
        private int m_warehouseID;
        private bool m_isDBOpened;

        public GeneralController(IGeneralControllerListener listener, int userID, int userLevel) : base()
        {
            m_listener = listener;
            m_currentUserID = userID;
            m_currentUserAccess = userLevel;
            m_isDBOpened = true;
            m_warehouseID = -1;

            m_listener.onAccessLevelUpdate((Common.Types.Posts)m_currentUserAccess);
        }

        public void pauseResume()
        {
            if (m_isDBOpened)
            {
                m_db.close();
            }
            else
            {
                m_db.open();
            }

            m_isDBOpened = !m_isDBOpened;
        }

        public void initNewOrderSubController(NewOrder.NewOrderController ctrl)
        {
            ctrl.setDB(m_db);
        }

        public void loadWarehouseTopology(int id)
        {
            m_warehouseID = id;
            string json = m_db.getTopologyByID(id);
            m_currentTopology = JsonSerializer.Deserialize<Common.Types.Topology>(json);
            m_listener.onCurrentTopologyUpdate(m_currentTopology);
        }

        public void refreshWarehouseList()
        {
            var list = m_db.getRoomsIdentificatorList();
            m_listener.onWarehouseListUpdate(list);
        }

        public void refreshOrderList()
        {
            List<Order> orderlist = m_db.getOrders(m_warehouseID);
            m_listener.onOrderListUpdate(orderlist);
        }
        public void applyOrder(int orderID)
        {
            refreshOrderList();
        }

        public void cancelOrder(int orderID)
        {
            m_db.deleteOrder(orderID);
            refreshOrderList();
        }

        public OrderDescriptionData getOrderDescription(int orderID)
        {
            return m_db.getOrderDescription(orderID);
        }
    }
}
