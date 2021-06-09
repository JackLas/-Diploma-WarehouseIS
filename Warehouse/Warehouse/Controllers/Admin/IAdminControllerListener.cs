using System.Collections.Generic;

namespace Warehouse.Controllers.Admin
{
    interface IAdminControllerListener
    {
        public abstract void onLoginAlreadyExists();

        public abstract void onEmployeeAdded();

        public abstract void onEmployeeListUpdate(List<Common.Types.Employee> employees);

        public abstract void onClientAdded();

        public abstract void onClientListRefresh(List<Common.Types.Client> clientList);

        public abstract void onCurrentTopologyUpdate(Common.Types.Topology topology);
    }
}
