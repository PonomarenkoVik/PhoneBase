using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    class Number
    {
        public int PhoneNumber { get; set; }
        public int IdAccount { get; set; }
        public int IdTariff { get; set; }
        public int IdOper { get; set; }
        public int IdUser { get; set; }


        public static bool Add(SqlConnectionStringBuilder builder, int newNumber, int idTariff, int idOperator, int idUser)
        {
            string query = "AddNumber";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@newNumber", Value = newNumber, SqlDbType = SqlDbType.Int},
                new SqlParameter() {ParameterName = "@idTariff", Value = idTariff, SqlDbType = SqlDbType.Int},
                new SqlParameter() {ParameterName = "@idOperator", Value = idOperator, SqlDbType = SqlDbType.Int},
                new SqlParameter() {ParameterName = "@idUser", Value = idUser, SqlDbType = SqlDbType.Int},
                new SqlParameter(){ParameterName = "@status", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Output}
            };

            Connection.GetData(builder, query, true, parameters);
            return !((bool)parameters[4].Value);
        }
    }
}
