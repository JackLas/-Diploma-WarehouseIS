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
    public class Identificator
    {
        public int ID { get; set; }
        public string name { get; set; }

        public Identificator()
        {
            ID = -1;
        }

        public override string ToString()
        {
            return ID.ToString() + (name.Length > 0 ? ": " + name : "");
        }
    }
}
