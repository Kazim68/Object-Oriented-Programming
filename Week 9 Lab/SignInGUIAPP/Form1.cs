using SignInGUIAPP.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInGUIAPP
{
    public partial class MUserApp : Form
    {
        public MUserApp()
        {
            InitializeComponent();
            string path = "data.txt";
            if (MUserDL.ReadData(path))
            {
                MessageBox.Show("Data Loaded From File!");
            }
            else
            {
                MessageBox.Show("Data not Loaded!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignInUpButton_Click(object sender, EventArgs e)
        {
            if (SignInBox.Checked)
            {
                Form SignIn = new SignInForm();
                SignIn.Show();
                SignInBox.Checked = false;
            }
            else if (SignUpBox.Checked)
            {
                Form SignUp = new SignUpForm();
                SignUp.Show();
                SignUpBox.Checked = false;
            }
        }
    }
}
