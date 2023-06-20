namespace Problem1_Combo_Box_
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
            this.OptionsComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chosenLbl = new System.Windows.Forms.Label();
            this.OptionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OptionsComboBox
            // 
            this.OptionsComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.OptionsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.OptionsComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OptionsComboBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsComboBox.FormattingEnabled = true;
            this.OptionsComboBox.Items.AddRange(new object[] {
            "Python",
            "C++",
            "C#",
            "Java Script",
            "Java"});
            this.OptionsComboBox.Location = new System.Drawing.Point(143, 102);
            this.OptionsComboBox.Name = "OptionsComboBox";
            this.OptionsComboBox.Size = new System.Drawing.Size(145, 30);
            this.OptionsComboBox.TabIndex = 0;
            this.OptionsComboBox.SelectedIndexChanged += new System.EventHandler(this.OptionsComboBox_SelectedIndexChanged);
            // 
            // chosenLbl
            // 
            this.chosenLbl.AutoSize = true;
            this.chosenLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenLbl.Location = new System.Drawing.Point(148, 185);
            this.chosenLbl.Name = "chosenLbl";
            this.chosenLbl.Size = new System.Drawing.Size(146, 29);
            this.chosenLbl.TabIndex = 1;
            this.chosenLbl.Text = "Your Choice";
            // 
            // OptionTxtBox
            // 
            this.OptionTxtBox.Location = new System.Drawing.Point(353, 189);
            this.OptionTxtBox.Name = "OptionTxtBox";
            this.OptionTxtBox.Size = new System.Drawing.Size(292, 26);
            this.OptionTxtBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OptionTxtBox);
            this.Controls.Add(this.chosenLbl);
            this.Controls.Add(this.OptionsComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OptionsComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label chosenLbl;
        private System.Windows.Forms.TextBox OptionTxtBox;
    }
}

