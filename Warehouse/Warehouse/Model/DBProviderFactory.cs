/*
 * Warehouse (c) by Yevhenii Kryvyi
 *
 * Warehouse is licensed under a
 * Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License.
 *
 * You should have received a copy of the license along with this
 * work. If not, see <http://creativecommons.org/licenses/by-nc-nd/4.0/>. 
 */

using Common.Interfaces;
using PGPresentation;
using System.Configuration;


namespace Warehouse.Model
{
    class DBProviderFactory
    {
        public static IDBProvider createProvider()
        {
            string type = ConfigurationManager.AppSettings.Get("db_type");
            switch (type)
            {
                case "postgres":
                    return new PostgreSQLProvider(ConfigurationManager.AppSettings.Get("db_ip"), ConfigurationManager.AppSettings.Get("db_port"));
                default: break;
            }
            return new PostgreSQLProvider(ConfigurationManager.AppSettings.Get("db_ip"), ConfigurationManager.AppSettings.Get("db_port"));
        }
    }
}
