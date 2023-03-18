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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = "у=k1x+b1";
            label1.Text = "у=k2x+b2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "")
            {
                if (textBox1.Text.All(char.IsDigit) & textBox2.Text.All(char.IsDigit) & textBox3.Text.All(char.IsDigit) & textBox4.Text.All(char.IsDigit) & textBox5.Text.All(char.IsDigit))
                {
                    if (textBox4.Text == textBox5.Text)
                    {
                        int y1 = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                        int y11 = Convert.ToInt32(textBox4.Text) * Convert.ToInt32(textBox6.Text) - Convert.ToInt32(textBox2.Text);

                        int y2 = Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox3.Text);
                        int y22 = Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox6.Text) - Convert.ToInt32(textBox3.Text);

                        int distanceBetween = Math.Abs(y1 - y2);
                        label4.Text = Convert.ToString(distanceBetween);
                    }
                }
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.BranchingChoice.Show();
            this.Hide();
        }
    }
}
