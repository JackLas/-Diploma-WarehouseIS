/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

namespace Common.Types
{
    public class OrderItem
    {
        public OrderItem()
        {
            id = -1;
            pos = new Vec();
            room_id = -1;
            item_id = -1;
            name = string.Empty;
            level = -1;
        }
        public int id { get; set; }
        public int room_id { get; set; }
        public int item_id { get; set; }
        public string name { get; set; }
        public Vec pos { get; set; }
        public int level { get; set; }
    }
}
