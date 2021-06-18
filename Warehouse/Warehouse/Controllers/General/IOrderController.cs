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

namespace Warehouse.Controllers.General
{
    public interface IOrderController
    {
        public abstract void applyOrder(int orderID);

        public abstract void cancelOrder(int orderID);

        public abstract OrderDescriptionData getOrderDescription(int orderID);
    }
}
