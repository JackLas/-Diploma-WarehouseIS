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
            var desc = m_db.getOrderDescription(orderID);

            foreach (var item in desc.items)
            {   
                if (desc.type == OrderType.SEND)
                {
                    m_db.deleteItem(item.id);
                }
                else if (desc.type == OrderType.RECEIVE)
                {
                    var queuedItem = m_db.getQueuedItemByID(item.id);
                    if (queuedItem != null)
                    {
                        m_db.addItem(queuedItem.item_id, queuedItem.room_id, queuedItem.pos.x, queuedItem.pos.y, queuedItem.level);
                        m_db.deleteQueuedItem(item.id);
                    }
                }
            }

            m_db.deleteOrder(orderID);
            refreshOrderList();
            refreshItemList(m_warehouseID, "");
        }

        public void cancelOrder(int orderID)
        {
            var desc = m_db.getOrderDescription(orderID);

            foreach (var item in desc.items)
            {
                if (desc.type == OrderType.RECEIVE)
                {
                    m_db.deleteQueuedItem(item.id);
                }
            }

            m_db.deleteOrder(orderID);
            refreshOrderList();
            refreshItemList(m_warehouseID, "");
        }

        public OrderDescriptionData getOrderDescription(int orderID)
        {
            return m_db.getOrderDescription(orderID);
        }

        public void refreshItemList(int warehouseID, string search)
        {
            var list = m_db.getItems(warehouseID, search);
            m_listener.onItemListUpdate(list);
        }
    }
}
