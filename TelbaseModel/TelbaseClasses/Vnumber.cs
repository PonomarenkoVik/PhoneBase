using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    class Vnumber
    {
        public int Number { get; set; }
        public string OperatorName { get; set; }
        public int IdAccount { get; set; }
        public string TarifName { get; set; }
        public long INN { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserSurname { get; set; }
        public decimal Cash { get; set; }
        public int FreeMinutesInneS { get; set; }
        public int FreeMinutesOutNetS { get; set; }


        public static DataTable FindByNumber(SqlConnectionStringBuilder builder, int number)
        {
            string query = "FindNumbers";
            SqlParameter[] parameters =
            {
                new SqlParameter() {ParameterName = "@number", Value = number, SqlDbType = SqlDbType.Int},
            };
            var table = Connection.GetData(builder, query, true, parameters);
            if (table != null)
            {
                table.Columns["OperatorName"].ColumnName = "Operator Name";
                table.Columns["IdAccount"].ColumnName = "Account";
                table.Columns["TarifName"].ColumnName = "Tariff";
                table.Columns["UserName"].ColumnName = "Name";
                table.Columns["UserPatronymic"].ColumnName = "Patronymic";
                table.Columns["UserSurname"].ColumnName = "Surname";

            }
            
            return table; 
        }


    }
}
