namespace SignInGUIAPP
{
    partial class MUserApp
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
            this.SignInBox = new System.Windows.Forms.CheckBox();
            this.SignUpBox = new System.Windows.Forms.CheckBox();
            this.SignInUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignInUpHeader
            // 
            this.SignInUpHeader.AutoSize = true;
            this.SignInUpHeader.BackColor = System.Drawing.SystemColors.Menu;
            this.SignInUpHeader.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInUpHeader.Location = new System.Drawing.Point(212, 49);
            this.SignInUpHeader.Name = "SignInUpHeader";
            this.SignInUpHeader.Size = new System.Drawing.Size(389, 32);
            this.SignInUpHeader.TabIndex = 0;
            this.SignInUpHeader.Text = "Sign Up Sign In Application";
            // 
            // SignInBox
            // 
            this.SignInBox.AutoSize = true;
            this.SignInBox.Location = new System.Drawing.Point(218, 218);
            this.SignInBox.Name = "SignInBox";
            this.SignInBox.Size = new System.Drawing.Size(85, 24);
            this.SignInBox.TabIndex = 1;
            this.SignInBox.Text = "Sign In";
            this.SignInBox.UseVisualStyleBackColor = true;
            // 
            // SignUpBox
            // 
            this.SignUpBox.AutoSize = true;
            this.SignUpBox.Location = new System.Drawing.Point(516, 218);
            this.SignUpBox.Name = "SignUpBox";
            this.SignUpBox.Size = new System.Drawing.Size(92, 24);
            this.SignUpBox.TabIndex = 2;
            this.SignUpBox.Text = "Sign Up";
            this.SignUpBox.UseVisualStyleBackColor = true;
            // 
            // SignInUpButton
            // 
            this.SignInUpButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SignInUpButton.Location = new System.Drawing.Point(365, 330);
            this.SignInUpButton.Name = "SignInUpButton";
            this.SignInUpButton.Size = new System.Drawing.Size(102, 37);
            this.SignInUpButton.TabIndex = 3;
            this.SignInUpButton.Text = "Next";
            this.SignInUpButton.UseVisualStyleBackColor = false;
            this.SignInUpButton.Click += new System.EventHandler(this.SignInUpButton_Click);
            // 
            // MUserApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignInUpButton);
            this.Controls.Add(this.SignUpBox);
            this.Controls.Add(this.SignInBox);
            this.Controls.Add(this.SignInUpHeader);
            this.Name = "MUserApp";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignInUpHeader;
        private System.Windows.Forms.CheckBox SignInBox;
        private System.Windows.Forms.CheckBox SignUpBox;
        private System.Windows.Forms.Button SignInUpButton;
    }
}

