using TelbaseModel;

namespace TelBaseUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.FindNumber = new System.Windows.Forms.Button();
            this.AddNumberButton = new System.Windows.Forms.Button();
            this.DeleteNumberButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusString = new System.Windows.Forms.ToolStripStatusLabel();
            this.FindUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTable
            // 
            this.MainTable.AccessibleDescription = "";
            this.MainTable.AccessibleName = "";
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainTable.Location = new System.Drawing.Point(101, 14);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowTemplate.ReadOnly = true;
            this.MainTable.Size = new System.Drawing.Size(1056, 576);
            this.MainTable.TabIndex = 0;
            this.MainTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainTable_CellContentClick);
            this.MainTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MainTable_CellMouseDoubleClick);
            // 
            // FindNumber
            // 
            this.FindNumber.Location = new System.Drawing.Point(12, 14);
            this.FindNumber.Name = "FindNumber";
            this.FindNumber.Size = new System.Drawing.Size(75, 23);
            this.FindNumber.TabIndex = 1;
            this.FindNumber.Text = "Find number";
            this.FindNumber.UseVisualStyleBackColor = true;
            this.FindNumber.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // AddNumberButton
            // 
            this.AddNumberButton.Location = new System.Drawing.Point(12, 72);
            this.AddNumberButton.Name = "AddNumberButton";
            this.AddNumberButton.Size = new System.Drawing.Size(75, 23);
            this.AddNumberButton.TabIndex = 2;
            this.AddNumberButton.Text = "Add number";
            this.AddNumberButton.UseVisualStyleBackColor = true;
            this.AddNumberButton.Click += new System.EventHandler(this.AddNumberButton_Click);
            // 
            // DeleteNumberButton
            // 
            this.DeleteNumberButton.Location = new System.Drawing.Point(12, 130);
            this.DeleteNumberButton.Name = "DeleteNumberButton";
            this.DeleteNumberButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNumberButton.TabIndex = 3;
            this.DeleteNumberButton.Text = "Delete number";
            this.DeleteNumberButton.UseVisualStyleBackColor = true;
            this.DeleteNumberButton.Click += new System.EventHandler(this.DeleteNumberButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(12, 101);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Add user";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusString});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusString
            // 
            this.StatusString.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
            this.StatusString.Name = "StatusString";
            this.StatusString.Size = new System.Drawing.Size(0, 17);
            // 
            // FindUser
            // 
            this.FindUser.Location = new System.Drawing.Point(12, 43);
            this.FindUser.Name = "FindUser";
            this.FindUser.Size = new System.Drawing.Size(75, 23);
            this.FindUser.TabIndex = 6;
            this.FindUser.Text = "Find user";
            this.FindUser.UseVisualStyleBackColor = true;
            this.FindUser.Click += new System.EventHandler(this.FindUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 602);
            this.Controls.Add(this.FindUser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.DeleteNumberButton);
            this.Controls.Add(this.AddNumberButton);
            this.Controls.Add(this.FindNumber);
            this.Controls.Add(this.MainTable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone base";
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.Button FindNumber;
        private System.Windows.Forms.Button AddNumberButton;
        private System.Windows.Forms.Button DeleteNumberButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusString;
        private System.Windows.Forms.Button FindUser;
    }
}

