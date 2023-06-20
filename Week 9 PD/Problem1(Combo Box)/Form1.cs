using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem1_Combo_Box_
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            list.Add("Python");
            list.Add("C++");
            list.Add("Java Script");
        }

        private void OptionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OptionTxtBox.Text = OptionsComboBox.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OptionsComboBox.DataSource = list;
            OptionsComboBox.Text = "Choose Option";
        }
    }
}
