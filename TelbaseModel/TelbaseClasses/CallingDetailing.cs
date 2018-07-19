using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    class CallingDetailing
    {
        public long IdCall { get; set; }
        public int Number { get; set; }
        public bool Direction { get; set; }
        public bool WithinNet { get; set; }
        public int IdConnNumber { get; set; }
        public DateTime Start { get; set; }
        public DateTime Duration { get; set; }
        public decimal? Price { get; set; }


        public static DataTable GetByNumber(SqlConnectionStringBuilder builder, int number)
        {
            string query = "GetCallingDetailingsByNumber";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@number", Value = number, SqlDbType = SqlDbType.Int},
            };

            return Connection.GetData(builder, query, true, parameters);
        }
    }
}
