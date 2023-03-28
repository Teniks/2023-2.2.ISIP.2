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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double A;
                try
                {
                    string input = Convert.ToString(textBox1.Text);
                    A = Program.DoubleFromText(input);
                }
                catch
                {
                    MessageBox.Show("Нужны цифры", "Проблема");
                    return;
                }

                label2.Text = "";
                if (A > 0 || A < 0)
                {
                    if(A > 0)
                    {
                        for (int i = 1; i <= A; i++)
                        {
                            double square = Math.Pow(i, 2);
                            int output = Convert.ToInt32(Math.Round(square));

                            label2.Text += " " + output;
                        }
                    }
                    else
                    {
                        for (int i = -1; i >= A; i--)
                        {
                            double square = Math.Pow(i, 2);
                            int output = Convert.ToInt32(Math.Round(square));

                            label2.Text += " " + output;
                        }
                    }
                }
                else
                {
                    label2.Text = "0";
                }
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Sets.Show();
            Program.While.Hide();
        }
    }
}
