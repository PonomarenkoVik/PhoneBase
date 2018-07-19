using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelBaseUI
{
    public interface ITelbaseView
    {

        SqlConnectionStringBuilder Connection { get; set; }
        EventHandler FindNumberButtonClick { get; set; }
        EventHandler FindUserButtonClick { get; set; }
        EventHandler ShowCallingDetailings { get; set; }
        EventHandler AddUserButtonClick{ get; set; }
        string Status { set; }
        IListSource MainTableSource { set; }
    }
}
