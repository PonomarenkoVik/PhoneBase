using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TelbaseModel
{
   
    public static class Connection
    {
        public static DataTable GetData(SqlConnectionStringBuilder builder, string query, bool typeQuery, params SqlParameter[] param)
        {
            DataTable result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    if (typeQuery)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (var sqlParameter in param)
                        {
                            cmd.Parameters.Add(sqlParameter);
                        }
                       
                    }

                   
                    connection.Open();
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());
                    if (table.Rows.Count > 0)
                    {
                        result = table;
                    }
                    connection.Close();
                }
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show(e.ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;
            }

            
            return result;
        }
    }
}
