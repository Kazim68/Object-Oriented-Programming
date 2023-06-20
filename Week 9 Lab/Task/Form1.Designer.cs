namespace Task
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
            this.button2 = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.CheckBox();
            this.Option2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(375, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(424, 49);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(0, 20);
            this.Answer.TabIndex = 6;
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(394, 135);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(91, 24);
            this.Option1.TabIndex = 7;
            this.Option1.Text = "Option1";
            this.Option1.UseVisualStyleBackColor = true;
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(394, 186);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(91, 24);
            this.Option2.TabIndex = 8;
            this.Option2.Text = "Option2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.CheckBox Option1;
        private System.Windows.Forms.CheckBox Option2;
    }
}

