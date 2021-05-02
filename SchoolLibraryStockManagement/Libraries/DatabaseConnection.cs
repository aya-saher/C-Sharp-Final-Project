using System.Configuration;
using System.Data;
using System.Data.Common;

namespace SchoolLibraryStockManagement.Libraries
{
    class DatabaseConnection
    {
        private static string database_connection_String;
        private static string database_provider;


        static DatabaseConnection()
        {

            database_connection_String = ConfigurationManager.ConnectionStrings["StockManagementConnectionStrings"].ConnectionString;
            database_provider = ConfigurationManager.ConnectionStrings["StockManagementConnectionStrings"].ProviderName;
        }

        public static DbCommand getConnection()
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(database_provider);

            DbConnection connection = factory.CreateConnection();

            connection.ConnectionString = database_connection_String;

            return connection.CreateCommand();
        }
    }
}
