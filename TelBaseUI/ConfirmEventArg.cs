using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelBaseUI
{
    class ConfirmEventArgs:EventArgs
    {
        public ConfirmEventArgs(bool confirm)
        {
            Confirm = confirm;
        }
        public bool Confirm { get; private set; }
    }
}
