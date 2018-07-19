using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelBaseUI
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm(string head)
        {
            InitializeComponent();
            Head.Text = head;
        }

        public EventHandler Confirm;
        private void NotConfirmButton_Click(object sender, EventArgs e)
        {
            if ( Confirm != null)
            {
                Confirm(this, new ConfirmEventArgs(false));
            }
            Close();        
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if ( Confirm != null)
            {
                Confirm(this, new ConfirmEventArgs(true));
            }
           Close();
        }

    }
}
