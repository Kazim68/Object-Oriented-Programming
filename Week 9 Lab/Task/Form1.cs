using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Task123()
        {
            //Txt1.Text = "Hello World!";
        }

        public void Task4()
        {
            Answer.Visible = true;
            /*if (Txt1.Text == Txt2.Text)
            {
                Answer.Text = "Same";
            }
            else { Answer.Text = "Different"; }*/
        }

        public void Task5()
        {
            Answer.Visible = true;
            if (Option1.Checked) { Answer.Text = "Option 1 Checked!"; }
            else if (Option2.Checked) { Answer.Text = "Option 2 Checked!"; }
            else { Answer.Text = "No option selected"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task5();
        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
