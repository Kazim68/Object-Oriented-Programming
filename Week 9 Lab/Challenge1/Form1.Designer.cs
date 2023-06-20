namespace Challenge1
{
    partial class Form1
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
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.NextColor = new System.Windows.Forms.Button();
            this.BackColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColorBox
            // 
            this.ColorBox.Location = new System.Drawing.Point(282, 109);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(239, 26);
            this.ColorBox.TabIndex = 0;
            // 
            // NextColor
            // 
            this.NextColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NextColor.Location = new System.Drawing.Point(523, 245);
            this.NextColor.Name = "NextColor";
            this.NextColor.Size = new System.Drawing.Size(106, 33);
            this.NextColor.TabIndex = 1;
            this.NextColor.Text = "Next";
            this.NextColor.UseVisualStyleBackColor = false;
            this.NextColor.Click += new System.EventHandler(this.NextColor_Click);
            // 
            // BackColor
            // 
            this.BackColor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackColor.Location = new System.Drawing.Point(205, 245);
            this.BackColor.Name = "BackColor";
            this.BackColor.Size = new System.Drawing.Size(106, 33);
            this.BackColor.TabIndex = 1;
            this.BackColor.Text = "Back";
            this.BackColor.UseVisualStyleBackColor = false;
            this.BackColor.Click += new System.EventHandler(this.BackColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackColor);
            this.Controls.Add(this.NextColor);
            this.Controls.Add(this.ColorBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Button NextColor;
        private System.Windows.Forms.Button BackColor;
    }
}

