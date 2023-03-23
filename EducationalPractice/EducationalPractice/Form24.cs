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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void Form24_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Lists.Show();
            Program.Subroutines.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Program.DoubleFromText(textBox1.Text);
            double b = Program.DoubleFromText(textBox2.Text);
            double c = Program.DoubleFromText(textBox3.Text);

            Median(ref a, ref b, ref c);

            textBox4.Text = Convert.ToString(a);
            textBox5.Text = Convert.ToString(b);
            textBox6.Text = Convert.ToString(c);
        }

        public void Median(ref double m, ref double n, ref double k)
        {
            double a, b, c;

            a = 0.5 * (Math.Sqrt(Math.Pow((2 * n), 2) + Math.Sqrt(Math.Pow((2 * k), 2) - Math.Pow(m, 2))));
            b = 0.5 * (Math.Sqrt(Math.Pow((2 * m), 2) + Math.Sqrt(Math.Pow((2 * k), 2) - Math.Pow(n, 2))));
            c = 0.5 * (Math.Sqrt(Math.Pow((2 * m), 2) + Math.Sqrt(Math.Pow((2 * n), 2) - Math.Pow(k, 2))));

            if (a < b + c && b < a + c && c < a + b)
            {
                m = a;
                n = b;
                k = c;
            }
            else
            {
                MessageBox.Show("Треугольник с такими сторонами не существует","Проблема");
                m = 0;
                n = 0;
                k = 0;
            }

        }
    }
}
