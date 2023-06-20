using LoginAppGUI_Grid.DL;
using LoginAppGUI_Grid.BL;
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
    public partial class ViewUsersForm : Form
    {
        public ViewUsersForm()
        {
            InitializeComponent();
            MUserDL.ReadData("data.txt"); // reading data from file
        }

        private void ViewUsersForm_Load(object sender, EventArgs e)
        {
            usersGrid.DataSource = MUserDL.getUsers(); // giving data source to grid and hiding password
            usersGrid.Columns["Password"].Visible = false;
        }

        private void usersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MUser user = (MUser)usersGrid.CurrentRow.DataBoundItem; // get user from row click
            if (usersGrid.Columns["Delete"].Index == e.ColumnIndex) 
            {
                MUserDL.removeFromList(user); // deleting from list
            }
            else if (usersGrid.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditUserForm form = new EditUserForm(user); // opening new form
                this.Visible = false;   // hiding this one
                form.ShowDialog();      // form performs it's working
                this.Visible = true;    // making this form visible
            }
            MUserDL.writeData("data.txt");
            updateGrid();
        }

        private void updateGrid()
        {
            usersGrid.DataSource = null;
            usersGrid.DataSource = MUserDL.getUsers();
            usersGrid.Columns["Password"].Visible = false;
            usersGrid.Refresh();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(); 
            this.Visible = false;
            form.ShowDialog();
            updateGrid();
            MUserDL.writeData("data.txt");
            this.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
