using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    public interface ITelbase
    {
        SqlConnectionStringBuilder Connection { get; set; }
        string AddUser(long inn, string name, string patronimic, string surname);
        DataTable FindUser(long inn, string name, string patronimic, string surname);
        bool AddNumber(int newNumber, int idTariff, int idOperator, int idUser);
        bool Refill(int idAccount, float summ, int freeMinin, int freeMinOut);
        DataTable FindVNumber(int number);
        DataTable GetRefillsByNumber(int number);
        DataTable GetCallDetailingByNumber(int number);


    }
}
