/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using System.Collections.Generic;

namespace Warehouse.Controllers.Admin
{
    public interface IAdminControllerListener
    {
        public abstract void handleNotification(string msg);

        public abstract void onLoginAlreadyExists();

        public abstract void onEmployeeAdded();

        public abstract void onEmployeeListUpdate(List<Common.Types.Employee> employees);

        public abstract void onClientAdded();

        public abstract void onClientListRefresh(List<Common.Types.Client> clientList);

        public abstract void onCurrentTopologyUpdate(Common.Types.Topology topology);

        public abstract void onNewShelfAdded();

        public abstract void onShelfListRefresh(List<Common.Types.Shelf> shelfList);

        public abstract void onTopologySaved();
    }
}
