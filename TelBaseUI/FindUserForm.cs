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
    public partial class FindUserForm : Form
    {
        public FindUserForm()
        {
            InitializeComponent();
        }

        public EventHandler FindButtonClick;

        private void FindButton_Click(object sender, EventArgs e)
        {
            long inn = 0;
            long.TryParse(INN.Text, out inn);
            TelEventArgs arg = new TelEventArgs(inn:inn, name:UserName.Text, patronymic:Patronymic.Text, surname:Surname.Text);
            if (FindButtonClick != null)
            {
                FindButtonClick(this, arg);
            }
        }
    }
}
