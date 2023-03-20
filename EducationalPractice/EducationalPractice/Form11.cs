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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Sets.Show();
            Program.Recursion.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "";

                int m1 = Convert.ToInt32(Program.DoubleFromText(textBox1.Text));
                int n1 = Convert.ToInt32(Program.DoubleFromText(textBox2.Text));
                int m2 = Convert.ToInt32(Program.DoubleFromText(textBox3.Text));
                int n2 = Convert.ToInt32(Program.DoubleFromText(textBox4.Text));

                label1.Text = Convert.ToString(Program.C(m1, n1) + Program.C(m1, n1));
            }
            catch
            {

            }
           


        }

        

    }
}
