using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using TelbaseModel;
using TelbaseModel.TelbaseClasses;

namespace TelBaseUI
{
    public partial class MainForm : Form,ITelbaseView
    {
        public MainForm(SqlConnectionStringBuilder connection)
        {
            InitializeComponent();
            Connection = connection;

        }


        public SqlConnectionStringBuilder Connection { get;  set; }
        public EventHandler FindNumberButtonClick { get; set; }
        public EventHandler FindUserButtonClick { get; set; }
        public EventHandler AddUserButtonClick { get; set; }
        public EventHandler ShowCallingDetailings { get; set; }

        public string Status
        {
            set
            {
                StatusString.Text = value;
            }
        }

        private void MainTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindNumberForm form = new FindNumberForm();
            if (FindNumberButtonClick != null)
            {
                form.Find = FindNumberButtonClick;
            }
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void DeleteNumberButton_Click(object sender, EventArgs e)
        {

        }

        private void AddNumberButton_Click(object sender, EventArgs e)
        {
           
        }


        private void MainTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            DataGridView table = (DataGridView)sender;
            int number = (int)table.Rows[index].Cells[0].Value;

            TelEventArgs arg = new TelEventArgs(number);
            if (ShowCallingDetailings != null)
            {
                ShowCallingDetailings(this, arg);
            }

        }

        

        public IListSource MainTableSource
        {
            set
            {
                MainTable.DataSource = value;
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm();

            if (AddUserButtonClick != null)
            {
                form.AddUserClick = AddUserButtonClick;
            }
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void FindUser_Click(object sender, EventArgs e)
        {
            FindUserForm form = new FindUserForm();

            if (AddUserButtonClick != null)
            {
                form.FindButtonClick= FindUserButtonClick;
            }
          
            form.Show();
        }
    }
}
