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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "" & textBox4.Text != "" & textBox5.Text != "")
            {
                if (textBox1.Text.All(char.IsDigit) & textBox2.Text.All(char.IsDigit) & textBox3.Text.All(char.IsDigit) & textBox4.Text.All(char.IsDigit) & textBox5.Text.All(char.IsDigit))
                {
                    int x = Convert.ToInt32(textBox1.Text ?? "-1");
                    int y = Convert.ToInt32(textBox2.Text ?? "-1");
                    int z = Convert.ToInt32(textBox3.Text ?? "-1");
                    int a = Convert.ToInt32(textBox4.Text ?? "-1");
                    int b = Convert.ToInt32(textBox5.Text ?? "-1");

                    if (x <= b & a <= x)
                    {
                        x = 0;
                    }
                    else
                    {
                        x = 1;
                    }

                    if (y <= b & a <= y)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = 1;
                    }

                    if (z <= b & a <= z)
                    {
                        z = 0;
                    }
                    else
                    {
                        z = 1;
                    }

                    textBox1.Text = Convert.ToString(x);
                    textBox2.Text = Convert.ToString(y);
                    textBox3.Text = Convert.ToString(z);
                    textBox4.Text = Convert.ToString(a);
                    textBox5.Text = Convert.ToString(b);
                }
            }
            

          
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.BranchingChoice.Show();
            this.Hide();
        }
    }
}
