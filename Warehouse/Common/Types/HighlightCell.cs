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
    public class HighlightCell
    {
        public HighlightCell(int _x = -1, int _y = -1, int _z = -1)
        {
            x = _x;
            y = _y;
            z = _z;

        }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }
}
