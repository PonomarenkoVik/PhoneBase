using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    sealed class User
    {
         
        public int? IdUser { get; set; }
        public long INN { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserSurname { get; set; }

        public static bool Add(SqlConnectionStringBuilder builder, long inn, string name, string patronimic, string surname)
        {
            string query = "AddUser";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@INN", Value = inn, SqlDbType = SqlDbType.BigInt},
                new SqlParameter() {ParameterName = "@name", Value = name, SqlDbType = SqlDbType.VarChar},
                new SqlParameter() {ParameterName = "@Patronimic", Value = patronimic, SqlDbType = SqlDbType.VarChar},
                new SqlParameter() {ParameterName = "@surname", Value = surname, SqlDbType = SqlDbType.VarChar},
                new SqlParameter(){ParameterName = "@status", SqlDbType = SqlDbType.Bit, Direction = ParameterDirection.Output}
            };

            Connection.GetData(builder, query, true, parameters);
            return !((bool)parameters[4].Value);
        }

        public static DataTable Find(SqlConnectionStringBuilder builder, long inn, string name, string patronimic, string surname)
        {
            string query = "FindUser";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@INN", Value = inn, SqlDbType = SqlDbType.BigInt},
                new SqlParameter() {ParameterName = "@name", Value = name, SqlDbType = SqlDbType.VarChar},
                new SqlParameter() {ParameterName = "@Patronymic", Value = patronimic, SqlDbType = SqlDbType.VarChar},
                new SqlParameter() {ParameterName = "@surname", Value = surname, SqlDbType = SqlDbType.VarChar},
            };

            return Connection.GetData(builder, query, true, parameters);
        }

    }
}
