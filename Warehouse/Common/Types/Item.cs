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
    public class Item
    {
        public Item()
        {
            id = -1;
            dim = new Dimensions();
            shelf_pos = new Vec();
            shelf_level = -1;
        }

        public int id { get; set; }
        public string name { get; set; }
        public Dimensions dim { get; set; }
        public Vec shelf_pos { get; set; }
        public int shelf_level { get; set; }
    }
}
