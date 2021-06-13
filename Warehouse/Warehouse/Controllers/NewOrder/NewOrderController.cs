using Common.Types;
using System.Collections.Generic;
using System.Text.Json;

namespace Warehouse.Controllers.NewOrder
{
    public class NewOrderController
    {
        private INewOrderListener m_listener;
        private bool m_isReceiveMode;
        private Common.Interfaces.IDBProvider m_db;
        private int m_warehouseID;
        private Dictionary<KeyValuePair<int , int>, int> m_shelfLevelsMapper;

        private List<OrderItem> m_order;

        public NewOrderController(INewOrderListener listener, int currentWarehouseID)
        {
            m_shelfLevelsMapper = new Dictionary<KeyValuePair<int, int>, int>();
            m_listener = listener;
            m_isReceiveMode = true;
            m_warehouseID = currentWarehouseID;
            m_order = new List<OrderItem>();
        }

        public void setDB(Common.Interfaces.IDBProvider db)
        {
            m_db = db;
        }

        public void switchMode(bool isReceive)
        {
            if (m_isReceiveMode != isReceive)
            {
                m_isReceiveMode = isReceive;

                m_order = new List<OrderItem>();
                m_listener.onOrderListUpdate(m_order);
                m_listener.onModeUpdate();
            }
        }

        public void refreshClientList()
        {
            var clients = m_db.getClients();
            m_listener.onClientListUpdate(clients);
        }

        public void refreshShelfList()
        {
            var topologyJson = m_db.getTopologyByID(m_warehouseID);
            var topology = JsonSerializer.Deserialize<Topology>(topologyJson);
            var shelfList = topology.getShelfList();

            List<Vec> result = new List<Vec>(); 
            foreach (var shelf in shelfList)
            {
                Vec vec = new Vec();
                vec.x = shelf.x;
                vec.y = shelf.y;
                result.Add(vec);

                var shelfData = m_db.getShelfByID(shelf.shelfID);
                if (shelfData != null)
                {
                    m_shelfLevelsMapper.Add(new KeyValuePair<int, int>(vec.x, vec.y), shelfData.levels);
                }
            }

            m_listener.onShelfListUpdate(result);
        }

        public void refreshCurrentShelfLevels(Vec shelfPos)
        {
            int levels = m_shelfLevelsMapper[new KeyValuePair<int, int>(shelfPos.x, shelfPos.y)];
            m_listener.onCurrentShelfLevelsUpdate(levels);
        }

        public void addToOrder(string name, int length, int width, int height, int weight, Vec pos, int shelfLevel)
        {
            int itemID = m_db.getItemID(name, length, width, height, weight);
            if (itemID == -1)
            {
                m_db.createItem(name, length, width, height, weight);
                itemID = m_db.getItemID(name, length, width, height, weight);
            }

            OrderItem item = new OrderItem();
            item.id = itemID;
            item.name = name;
            item.pos = pos;
            item.level = shelfLevel;

            m_order.Add(item);

            m_listener.onOrderListUpdate(m_order);
        }

        public void removeFromOrder(int index)
        {
            m_order.RemoveAt(index);
            m_listener.onOrderListUpdate(m_order);
        }

        public void refreshItemsAutocomplete()
        {

        }

        public void createOrder(int clientID)
        {
            if (m_isReceiveMode)
            {
                createReceiveOrder(clientID);
            }
            else
            {
                createSendOrder(clientID);
            }
        }

        private void createSendOrder(int clientID)
        {

        }

        private void createReceiveOrder(int clientID)
        {
            List<int> queueItemIDs = new List<int>();
            foreach (var item in m_order)
            {
                int id = m_db.addItemToReceiveQueue(item.id, m_warehouseID, item.pos.x, item.pos.y, item.level);
                queueItemIDs.Add(id);
            }

            m_db.createOrder(clientID, m_warehouseID, queueItemIDs, OrderType.RECEIVE);
        }
    }
}