using Problem2.BL;
using Problem2.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem2
{
    public partial class EditUserForm : Form
    {
        MUser user;
        public EditUserForm(MUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            NameTxtBox.Text = user.Name;
            PasswordTxtBox.Text = user.Password;
            RoleTxtBox.Text = user.Role;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            MUserDL.editUser(user, new MUser(NameTxtBox.Text, PasswordTxtBox.Text, RoleTxtBox.Text));
            this.Close();
        }
    }
}
