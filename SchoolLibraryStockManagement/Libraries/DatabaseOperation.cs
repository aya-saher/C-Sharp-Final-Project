using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolLibraryStockManagement.Libraries
{
    class DatabaseOperation
    {
        public static DataTable get(DataTable table, string query)
        {
            DbCommand command = DatabaseConnection.getConnection();
            command.CommandText = query;
            try
            {
                command.Connection.Open();
                DbDataReader reader = command.ExecuteReader();
                table.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                //throw;
            }
            finally
            {
                command.Connection.Close();
            }
            return table;
        }

        public static void create(string query)
        {
            DbCommand command = DatabaseConnection.getConnection();
            command.CommandText = query;

            try
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //throw;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}
