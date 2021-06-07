using System.Collections.Generic;

namespace Warehouse.Controllers.Admin
{
    interface IAdminControllerListener
    {
        public abstract void onLoginAlreadyExists();

        public abstract void onEmployeeAdded();

        public abstract void onEmployeeListUpdate(List<Common.Types.Employee> employees);
    }
}
