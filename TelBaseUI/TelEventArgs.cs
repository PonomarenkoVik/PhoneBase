using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelBaseUI
{
    class TelEventArgs:EventArgs
    {
        public TelEventArgs(int number = 0, long inn = 0, string name = null, string patronymic = null, string surname = null  )
        {
            Number = number;
            INN = inn;
            Name = name;
            Patronymic = patronymic;
            Surname = surname;
        }

        public int Number { get; private set; }
        public long INN { get; private set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Surname { get; set; }
    }
}
