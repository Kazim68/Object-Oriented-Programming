using LoginAppGUI_Grid.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAppGUI_Grid
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        public void blinkData()
        {
            NameTxtBox.Text = "";
            PasswordTxtBox.Text = "";
            RoleTxtBox.Text = "";
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            blinkData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            MUserDL.addInList(new BL.MUser(NameTxtBox.Text, PasswordTxtBox.Text, RoleTxtBox.Text));
            this.Close();
        }
    }
}
