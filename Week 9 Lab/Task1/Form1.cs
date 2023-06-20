using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            students.Add(new Student() { Id = 1, Name = "A", Age = 10 });
            students.Add(new Student() { Id = 2, Name = "B",Age = 11 });
            students.Add(new Student() { Id = 3, Name = "C", Age = 12 });

            dataGridView1.DataSource = students;
            // after selecting data source
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get student from cell clicked
            Student student = (Student)dataGridView1.CurrentRow.DataBoundItem;

            // remove from list
            students.Remove(student);

            // set data source to null
            dataGridView1.DataSource = null;

            // set the upated list to data source
            dataGridView1.DataSource = students;

            // refresh the grid
            dataGridView1.Refresh();
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
