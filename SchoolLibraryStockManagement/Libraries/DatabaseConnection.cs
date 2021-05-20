using System.Configuration;
using System.Data;
using System.Data.Common;

namespace SchoolLibraryStockManagement.Libraries
{
    class DatabaseConnection
    {
        private static DatabaseConnection database_connection = null;
        private static string database_connection_string;
        private static string database_provider;


        private DatabaseConnection()
        {

            database_connection_string = ConfigurationManager.ConnectionStrings["StockManagementConnectionStrings"].ConnectionString;
            database_provider = ConfigurationManager.ConnectionStrings["StockManagementConnectionStrings"].ProviderName;
        }

        public static DatabaseConnection SingletonInstance()
        {
            if (database_connection == null)
            {
                database_connection = new DatabaseConnection();
            }

            return database_connection;
        }

        public DbCommand getConnection()
        {
            DbProviderFactory factory = DbProviderFactories.GetFactory(database_provider);

            DbConnection connection = factory.CreateConnection();

            connection.ConnectionString = database_connection_string;

            return connection.CreateCommand();
        }
    }
}
