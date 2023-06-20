using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColorsDL.addColor("Red");
            ColorsDL.addColor("Green");
            ColorsDL.addColor("Blue");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorBox.BackColor = Color.Red;
        }

        private void NextColor_Click(object sender, EventArgs e)
        {
            ColorsDL.nextColor();
            ColorBox.BackColor = Color.FromName(ColorsDL.getColor());
        }

        private void BackColor_Click(object sender, EventArgs e)
        {
            ColorsDL.backColor();
            ColorBox.BackColor = Color.FromName(ColorsDL.getColor());
        }
    }
}
