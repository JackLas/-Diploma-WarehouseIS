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
            return null;
        }
    }
}
