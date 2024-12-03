using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TableToText
{
    class DataManager
    {
        public static DataTable GetDatabases(string serverName)
        {
            try
            {
                string connectionString = @"Data Source=" + serverName + "; Trusted_Connection=True; Initial Catalog = master";
                string queryString = "SELECT * FROM sys.databases ORDER BY CASE WHEN database_id <=4 THEN database_id ELSE 5 END, name";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable("DBnames");
                    DataColumn spName = dt.Columns.Add("DBName", typeof(string));
                    DataRow dr = null;
                    try
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine(String.Format("{0}, {1}", reader["tPatCulIntPatIDPk"], reader["tPatSFirstname"]));// etc
                            dr = dt.NewRow(); // have new row on each iteration
                            dr["DBName"] = reader["name"];
                            dt.Rows.Add(dr);
                        }
                        return dt;
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                DialogResult result1 = MessageBox.Show("GetStoredProcedureScripts Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
        public static DataTable GetTables(string serverName, string databaseName)
        {
            try
            {
                string connectionString = @"Data Source=" + serverName + "; Trusted_Connection=True; Initial Catalog = master";
                string queryString = "USE " + databaseName + "; SELECT * FROM information_schema.tables";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dt = new DataTable("tableNames");
                    DataColumn schemaName = dt.Columns.Add("Schema", typeof(string));
                    DataColumn tableName = dt.Columns.Add("Table Name", typeof(string));
                    DataRow dr = null;
                    try
                    {
                        while (reader.Read())
                        {
                            //Console.WriteLine(String.Format("{0}, {1}", reader["tPatCulIntPatIDPk"], reader["tPatSFirstname"]));// etc
                            dr = dt.NewRow(); // have new row on each iteration
                            dr["Schema"] = reader["TABLE_SCHEMA"];
                            dr["Table Name"] = reader["TABLE_NAME"];
                            dt.Rows.Add(dr);
                        }
                        return dt;
                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }
                }
            }
            catch (Exception e)
            {
                DialogResult result1 = MessageBox.Show("GetTables Error: " + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
    }

}

