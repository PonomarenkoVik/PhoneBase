using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelbaseModel.TelbaseClasses
{
    class Tariff
    {
        public int? IdTariff { get; set; }
        public string TarifName { get; set; }
        public int IdOperator { get; set; }
        public decimal CallInNet { get; set; }
        public decimal CallOutNet { get; set; }
        public int TimeInNetS { get; set; }
        public int TimeOutNetS { get; set; }

    }
}
