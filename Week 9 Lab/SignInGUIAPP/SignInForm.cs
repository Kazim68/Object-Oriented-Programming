using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignInGUIAPP.BL;
using SignInGUIAPP.DL;

namespace SignInGUIAPP
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void CLearDataFromForm()
        {
            GetNameTxtBox.Text = "";
            GetPasswordTxtBox.Text = "";
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInNextButton_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(GetNameTxtBox.Text, GetPasswordTxtBox.Text);
            MUser validUser = MUserDL.SignIn(user);
            if (validUser != null)
            {
                MessageBox.Show("Valid User");
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            CLearDataFromForm();
        }
    }
}
