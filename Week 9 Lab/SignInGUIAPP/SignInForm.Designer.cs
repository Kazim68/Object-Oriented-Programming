namespace SignInGUIAPP
{
    partial class SignInForm
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
            this.GetPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.GetNameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SignInNextButton = new System.Windows.Forms.Button();
            this.SignInBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInUpHeader
            // 
            this.SignInUpHeader.AutoSize = true;
            this.SignInUpHeader.BackColor = System.Drawing.SystemColors.Menu;
            this.SignInUpHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInUpHeader.Location = new System.Drawing.Point(211, 37);
            this.SignInUpHeader.Name = "SignInUpHeader";
            this.SignInUpHeader.Size = new System.Drawing.Size(389, 32);
            this.SignInUpHeader.TabIndex = 2;
            this.SignInUpHeader.Text = "Sign Up Sign In Application";
            // 
            // GetPasswordTxtBox
            // 
            this.GetPasswordTxtBox.Location = new System.Drawing.Point(254, 209);
            this.GetPasswordTxtBox.Name = "GetPasswordTxtBox";
            this.GetPasswordTxtBox.Size = new System.Drawing.Size(397, 26);
            this.GetPasswordTxtBox.TabIndex = 10;
            // 
            // GetNameTxtBox
            // 
            this.GetNameTxtBox.Location = new System.Drawing.Point(254, 158);
            this.GetNameTxtBox.Name = "GetNameTxtBox";
            this.GetNameTxtBox.Size = new System.Drawing.Size(397, 26);
            this.GetNameTxtBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(142, 211);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(74, 20);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "Pasword:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(161, 160);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(55, 20);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // SignInNextButton
            // 
            this.SignInNextButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SignInNextButton.Location = new System.Drawing.Point(570, 338);
            this.SignInNextButton.Name = "SignInNextButton";
            this.SignInNextButton.Size = new System.Drawing.Size(104, 31);
            this.SignInNextButton.TabIndex = 12;
            this.SignInNextButton.Text = "Next";
            this.SignInNextButton.UseVisualStyleBackColor = false;
            this.SignInNextButton.Click += new System.EventHandler(this.SignInNextButton_Click);
            // 
            // SignInBackButton
            // 
            this.SignInBackButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SignInBackButton.Location = new System.Drawing.Point(217, 338);
            this.SignInBackButton.Name = "SignInBackButton";
            this.SignInBackButton.Size = new System.Drawing.Size(104, 31);
            this.SignInBackButton.TabIndex = 11;
            this.SignInBackButton.Text = "Back";
            this.SignInBackButton.UseVisualStyleBackColor = false;
            this.SignInBackButton.Click += new System.EventHandler(this.SignInBackButton_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignInNextButton);
            this.Controls.Add(this.SignInBackButton);
            this.Controls.Add(this.GetPasswordTxtBox);
            this.Controls.Add(this.GetNameTxtBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SignInUpHeader);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.SignInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInUpHeader;
        private System.Windows.Forms.TextBox GetPasswordTxtBox;
        private System.Windows.Forms.TextBox GetNameTxtBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SignInNextButton;
        private System.Windows.Forms.Button SignInBackButton;
    }
}