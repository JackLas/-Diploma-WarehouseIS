using Common.Types;
using System.Collections.Generic;

namespace Warehouse.Controllers.General
{
    interface IGeneralControllerListener
    {
        public abstract void onAccessLevelUpdate(Posts post);
        public abstract void onWarehouseListUpdate(List<Identificator> list);
        public abstract void onCurrentTopologyUpdate(Topology topology);
    }
}
