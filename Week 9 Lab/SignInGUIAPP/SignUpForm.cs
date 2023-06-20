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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CleatDataFromForm()
        {
            GetNameTxtBox.Text = "";
            GetPasswordTxtBox.Text = "";
            GetRoleTxtBox.Text = "";
        }

        private void SignUpNextButton_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(GetNameTxtBox.Text, GetPasswordTxtBox.Text, GetRoleTxtBox.Text);
            MUserDL.addInList(user);
            MUserDL.writeData(user, "Data.txt");
            MessageBox.Show("User Added Successfully");
            CleatDataFromForm();
        }
    }
}
