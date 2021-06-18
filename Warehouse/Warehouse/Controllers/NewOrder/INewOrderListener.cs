/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using Common.Types;
using System.Collections.Generic;

namespace Warehouse.Controllers.NewOrder
{
    public interface INewOrderListener
    {
        public abstract void onOrderListUpdate(List<OrderItem> list);

        public abstract void onClientListUpdate(List<Client> list);

        public abstract void onShelfListUpdate(List<Vec> list);

        public abstract void onCurrentShelfLevelsUpdate(int levels);

        public abstract void onModeUpdate();

        public abstract void onItemNameAutocompleteUpdate(List<string> list);

        public abstract void onAutocompleteMatch(List<Item> item);
    }
}
