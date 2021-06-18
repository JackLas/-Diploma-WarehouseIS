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

namespace Common.Types
{
    public class OrderDescriptionData
    {
        public OrderDescriptionData()
        {
            client = new Client();
            items = new List<OrderItem>();
        }
        public int id { get; set; }
        public Client client { get; set; }
        public List<OrderItem> items { get; set; }
        public OrderType type { get; set; }
    }
}
