namespace LoginAppGUI_Grid
{
    partial class EditUserForm
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
            this.NextBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.RoleTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.RoleLbl = new System.Windows.Forms.Label();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NextBtn.Location = new System.Drawing.Point(566, 352);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(139, 40);
            this.NextBtn.TabIndex = 15;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackBtn.Location = new System.Drawing.Point(131, 352);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(139, 40);
            this.BackBtn.TabIndex = 14;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RoleTxtBox
            // 
            this.RoleTxtBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.RoleTxtBox.Location = new System.Drawing.Point(305, 243);
            this.RoleTxtBox.Name = "RoleTxtBox";
            this.RoleTxtBox.Size = new System.Drawing.Size(385, 26);
            this.RoleTxtBox.TabIndex = 13;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PasswordTxtBox.Location = new System.Drawing.Point(305, 150);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(385, 26);
            this.PasswordTxtBox.TabIndex = 12;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.NameTxtBox.Location = new System.Drawing.Point(305, 65);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(385, 26);
            this.NameTxtBox.TabIndex = 11;
            // 
            // RoleLbl
            // 
            this.RoleLbl.AutoSize = true;
            this.RoleLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RoleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLbl.Location = new System.Drawing.Point(161, 243);
            this.RoleLbl.Name = "RoleLbl";
            this.RoleLbl.Size = new System.Drawing.Size(73, 32);
            this.RoleLbl.TabIndex = 10;
            this.RoleLbl.Text = "Role";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(96, 144);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(138, 32);
            this.PasswordLbl.TabIndex = 9;
            this.PasswordLbl.Text = "Password";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(145, 58);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(89, 32);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RoleTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.RoleLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.NameLbl);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.TextBox RoleTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Label RoleLbl;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label NameLbl;
    }
}