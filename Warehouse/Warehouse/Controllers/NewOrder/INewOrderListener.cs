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
