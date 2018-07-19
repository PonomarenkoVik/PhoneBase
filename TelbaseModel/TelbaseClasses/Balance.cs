using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    class Balance
    {
        public int IdAccount { get; set; }
        public decimal Cash { get; set; }
        public int FreeMinutesInneS { get; set; }
        public int FreeMinutesOutNetS { get; set; }
    }
}
