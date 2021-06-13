using Common.Types;
using System.Collections.Generic;

namespace Warehouse.Controllers.General
{
    public interface IGeneralControllerListener
    {
        public abstract void onAccessLevelUpdate(Posts post);
        public abstract void onWarehouseListUpdate(List<Identificator> list);
        public abstract void onCurrentTopologyUpdate(Topology topology);
        public abstract void onOrderListUpdate(List<Order> list);
    }
}
