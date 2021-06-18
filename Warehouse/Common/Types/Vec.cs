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
    public class Vec
    {
        public Vec()
        {
            x = -1;
            y = -1;
        }

        public int x { get; set; }
        public int y { get; set; }

        public override string ToString()
        {
            return "(" + x.ToString() + "; " + y.ToString() + ")";
        }
    }
}
