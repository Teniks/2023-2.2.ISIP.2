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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form23_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Screenshot_3.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Lists.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Program.DoubleFromText(textBox1.Text);
                double b = Program.DoubleFromText(textBox1.Text);
                double c = Program.DoubleFromText(textBox1.Text);

                textBox2.Text = Convert.ToString(WorkingWithMin(a, b, c));
            }
            catch
            {
                MessageBox.Show("Ввели числа?","Проблема");
            }
        }

        public double WorkingWithMin(double a,  double b, double c)
        {
            double z = a + b;
            double y = b + c;
            double x = z * c;

           return ((Min( ref a, ref z)) + Min (ref a, ref y))/(1 + (Min(ref x, ref b)));
        }

        public double Min(ref double a, ref double b)
        {
            if (a < b)
            {
                return a;
            }
            if (b < a)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }

}
