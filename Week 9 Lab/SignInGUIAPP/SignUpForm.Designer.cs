namespace SignInGUIAPP
{
    partial class SignUpForm
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
            this.SignInUpHeader = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.GetNameTxtBox = new System.Windows.Forms.TextBox();
            this.GetPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.GetRoleTxtBox = new System.Windows.Forms.TextBox();
            this.SignUpBackButton = new System.Windows.Forms.Button();
            this.SignUpNextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInUpHeader
            // 
            this.SignInUpHeader.AutoSize = true;
            this.SignInUpHeader.BackColor = System.Drawing.SystemColors.Menu;
            this.SignInUpHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInUpHeader.Location = new System.Drawing.Point(211, 48);
            this.SignInUpHeader.Name = "SignInUpHeader";
            this.SignInUpHeader.Size = new System.Drawing.Size(389, 32);
            this.SignInUpHeader.TabIndex = 1;
            this.SignInUpHeader.Text = "Sign Up Sign In Application";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(154, 152);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(135, 203);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(74, 20);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Pasword:";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(163, 260);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(46, 20);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Role:";
            // 
            // GetNameTxtBox
            // 
            this.GetNameTxtBox.Location = new System.Drawing.Point(247, 152);
            this.GetNameTxtBox.Name = "GetNameTxtBox";
            this.GetNameTxtBox.Size = new System.Drawing.Size(397, 26);
            this.GetNameTxtBox.TabIndex = 5;
            // 
            // GetPasswordTxtBox
            // 
            this.GetPasswordTxtBox.Location = new System.Drawing.Point(247, 203);
            this.GetPasswordTxtBox.Name = "GetPasswordTxtBox";
            this.GetPasswordTxtBox.Size = new System.Drawing.Size(397, 26);
            this.GetPasswordTxtBox.TabIndex = 6;
            // 
            // GetRoleTxtBox
            // 
            this.GetRoleTxtBox.Location = new System.Drawing.Point(247, 254);
            this.GetRoleTxtBox.Name = "GetRoleTxtBox";
            this.GetRoleTxtBox.Size = new System.Drawing.Size(397, 26);
            this.GetRoleTxtBox.TabIndex = 7;
            // 
            // SignUpBackButton
            // 
            this.SignUpBackButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SignUpBackButton.Location = new System.Drawing.Point(217, 351);
            this.SignUpBackButton.Name = "SignUpBackButton";
            this.SignUpBackButton.Size = new System.Drawing.Size(104, 31);
            this.SignUpBackButton.TabIndex = 8;
            this.SignUpBackButton.Text = "Back";
            this.SignUpBackButton.UseVisualStyleBackColor = false;
            this.SignUpBackButton.Click += new System.EventHandler(this.SignUpBackButton_Click);
            // 
            // SignUpNextButton
            // 
            this.SignUpNextButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SignUpNextButton.Location = new System.Drawing.Point(570, 351);
            this.SignUpNextButton.Name = "SignUpNextButton";
            this.SignUpNextButton.Size = new System.Drawing.Size(104, 31);
            this.SignUpNextButton.TabIndex = 9;
            this.SignUpNextButton.Text = "Next";
            this.SignUpNextButton.UseVisualStyleBackColor = false;
            this.SignUpNextButton.Click += new System.EventHandler(this.SignUpNextButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignUpNextButton);
            this.Controls.Add(this.SignUpBackButton);
            this.Controls.Add(this.GetRoleTxtBox);
            this.Controls.Add(this.GetPasswordTxtBox);
            this.Controls.Add(this.GetNameTxtBox);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SignInUpHeader);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInUpHeader;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.TextBox GetNameTxtBox;
        private System.Windows.Forms.TextBox GetPasswordTxtBox;
        private System.Windows.Forms.TextBox GetRoleTxtBox;
        private System.Windows.Forms.Button SignUpBackButton;
        private System.Windows.Forms.Button SignUpNextButton;
    }
}