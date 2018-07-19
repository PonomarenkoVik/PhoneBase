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
    public partial class FindNumberForm : Form
    {
        public FindNumberForm()
        {
            InitializeComponent();
        }

        public EventHandler Find;

        private void FindButton_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(TelNumber.Text, out num))
            {              
                if (Find != null)
                {
                    Find(this, new TelEventArgs(num));         
                }
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect number", "Error");
            }

        }

    }
}
