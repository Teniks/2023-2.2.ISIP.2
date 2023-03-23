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
    public partial class Form25 : Form
    {
        public Form25()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Lists.Show();
            Program.Division.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            double result = 0;

            if (MathExpression(ref t1, ref t2, ref t3) % 4 == 0)
            {
                result = MathExpression(ref t1, ref t2, ref t3);
            }
            if (MathExpression(ref t1, ref t2, ref t3) % 4 == 1 || MathExpression(ref t1, ref t2, ref t3) % 4 == 3)
            {
                result = MathExpression(ref t1, ref t2, ref t3) - (MathExpression(ref t1, ref t2, ref t3) % 4);
            }
            if(MathExpression(ref t1, ref t2, ref t3) % 4 == 2)
            {
                result = MathExpression(ref t1, ref t2, ref t3) + (MathExpression(ref t1, ref t2, ref t3) % 4);
            }

            MessageBox.Show(Convert.ToString(MathExpression(ref t1, ref t2, ref t3) % 4),"Остаток");
            textBox4.Text = Convert.ToString(result);
         
        }

        public double MathExpression(ref string text1, ref string text2, ref string text3)
        {
            double a = Program.DoubleFromText(text1);
            double b = Program.DoubleFromText(text2);
            double k = Program.DoubleFromText(text3);
            double c = (k * (a + b));

            return c;
        }

    }
}
