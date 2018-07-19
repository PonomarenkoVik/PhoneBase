using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelbaseModel.TelbaseClasses
{
    public class TelbaseEntity:ITelbase
    {
        public TelbaseEntity()
        {

        }
        public SqlConnectionStringBuilder Connection { get; set; }

        public string AddUser(long inn, string name, string patronimic, string surname)
        {
            string result = "User not added";
            if ( User.Add(Connection, inn, name, patronimic, surname))
            {
                result = "User added";
            }
            return result;
        }

        public DataTable FindUser(long inn, string name, string patronimic, string surname)
        {
            return User.Find(Connection, inn, name, patronimic, surname);
        }

        public bool AddNumber(int newNumber, int idTariff, int idOperator, int idUser)
        {
            return Number.Add(Connection, newNumber, idTariff, idOperator, idUser);
        }

        public bool Refill(int idAccount, float summ, int freeMinin, int freeMinOut)
        {
            return Refilling.Refill(Connection, idAccount, summ, freeMinin, freeMinOut);
        }

        public DataTable FindVNumber(int number)
        {
            return Vnumber.FindByNumber(Connection, number);
        }

        public DataTable GetRefillsByNumber(int number)
        {  
            return Refilling.GetByNumber(Connection, number);            
        }

        public DataTable GetCallDetailingByNumber(int number)
        {          
            return CallingDetailing.GetByNumber(Connection,number);            
        }

      
    }
}
