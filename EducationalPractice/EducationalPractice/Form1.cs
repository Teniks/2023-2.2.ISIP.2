using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Bridge.Show();
            Program.Center.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Sets.Show();
            Program.Center.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.WorkingWithLists.Show();
            Program.Center.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Lists.Show();
            Program.Center.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.Charts.Show();
            Program.Center.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.Animation.Show();
            Program.Center.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.TextFiles.Show();
            Program.Center.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.Notes.Show();
            Program.Center.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.WorkWithTypedFiles.Show();
            Program.Center.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.Reference.Show();
            Program.Center.Hide();
        }
    }
}
