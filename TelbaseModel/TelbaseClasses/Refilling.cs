using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    class Refilling
    {
        public int? IdRefills { get; set; }
        public int IdAccount { get; set; }
        public decimal SumEntity { get; set; }
        public DateTime TimeRefill { get; set; }
        public bool ExecutionStatus { get; set; }



        public static DataTable GetByNumber(SqlConnectionStringBuilder builder,int number)
        {
            string query = "GetRefillsByNumber";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@number", Value = number, SqlDbType = SqlDbType.Int},
            };

            return Connection.GetData(builder, query, true, parameters);
        }



        public static bool Refill(SqlConnectionStringBuilder builder, int idAccount, float summ, int freeMinin, int freeMinOut)
        {
            string query = "RefillAccount";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@id", Value = idAccount, SqlDbType = SqlDbType.Int},
                new SqlParameter() {ParameterName = "@sum", Value = summ, SqlDbType = SqlDbType.Float},
                new SqlParameter() {ParameterName = "@freeMinIn", Value = freeMinin, SqlDbType = SqlDbType.Int},
                new SqlParameter() {ParameterName = "@freeMinOut", Value = freeMinOut, SqlDbType = SqlDbType.Int},
                new SqlParameter(){ParameterName = "@status", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Output}
            };

            Connection.GetData(builder, query, true, parameters);
            return !((bool)parameters[4].Value);
        }
    }
}
