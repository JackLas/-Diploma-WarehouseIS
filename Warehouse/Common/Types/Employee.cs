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
    public class Employee
    {
        public int id { get; set; }
        public int account_id { get; set; }
        public string fullName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}
