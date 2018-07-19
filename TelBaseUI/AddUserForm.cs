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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        public EventHandler AddUserClick;
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            long inn;
            if (long.TryParse(INN.Text, out inn) && UserName.Text !="" && Patronymic.Text != "" && Surname.Text != "")
            {
                if (AddUserClick != null)
                {
                    TelEventArgs arg = new TelEventArgs(inn: inn, name:UserName.Text, patronymic:Patronymic.Text, surname:Surname.Text);
                    AddUserClick(this, arg);
                    Close();
                } 
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
