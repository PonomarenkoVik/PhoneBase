namespace TelBaseUI
{
    partial class AddUserForm
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.INN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.CancelButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.Location = new System.Drawing.Point(187, 210);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(89, 31);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(145, 16);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(113, 20);
            this.INN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "INN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(145, 53);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(113, 20);
            this.UserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patronymic";
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(145, 88);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(113, 20);
            this.Patronymic.TabIndex = 5;
            // 
            // CancelButt
            // 
            this.CancelButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButt.Location = new System.Drawing.Point(39, 210);
            this.CancelButt.Name = "CancelButt";
            this.CancelButt.Size = new System.Drawing.Size(89, 31);
            this.CancelButt.TabIndex = 7;
            this.CancelButt.Text = "Cancel";
            this.CancelButt.UseVisualStyleBackColor = true;
            this.CancelButt.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surname";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(145, 125);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(113, 20);
            this.Surname.TabIndex = 8;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 271);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.CancelButt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Patronymic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.AddUserButton);
            this.Name = "AddUserForm";
            this.Text = "Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.Button CancelButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Surname;
    }
}