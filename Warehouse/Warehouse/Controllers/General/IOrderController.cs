using Common.Types;

namespace Warehouse.Controllers.General
{
    public interface IOrderController
    {
        public abstract void applyOrder(int orderID);

        public abstract void cancelOrder(int orderID);

        public abstract OrderDescriptionData getOrderDescription(int orderID);
    }
}
