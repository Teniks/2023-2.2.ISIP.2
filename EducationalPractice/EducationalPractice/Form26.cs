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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                double h, a, b, x, y, A;
                double h2, a2, b2, B;
                

                if (radioButton1.Checked)
                {
                    a2 = Program.DoubleFromText(textBox8.Text);
                    b2 = Program.DoubleFromText(textBox7.Text);
                    h2 = Program.DoubleFromText(textBox6.Text);
                    B = Program.DoubleFromText(textBox5.Text);

                    if (h2 == 0.0000000)
                    {
                        MessageBox.Show("Значение(я)  равны 0", "Проблема");
                        return;
                    }

                    x = a2;

                    while (x <= b2)
                    {
                        y = 1 - (B * Math.Sin(x + 0.5));
                        this.chart1.Series[1].Points.AddXY(x, y);
                        x += h2;
                    }
                    
                }
                if(radioButton2.Checked)
                {
                    a = Program.DoubleFromText(textBox1.Text);
                    b = Program.DoubleFromText(textBox2.Text);
                    h = Program.DoubleFromText(textBox3.Text);

                    A = Program.DoubleFromText(textBox4.Text);

                    if (h == 0.0000000)
                    {
                        MessageBox.Show("Значение(я) равны 0", "Проблема");
                        return;
                    }
                    x = a;

                    while (x <= b)
                    {
                        y = A * Math.Cos(x + 0.5) + 5;
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }
                }
                if (checkBox1.Checked)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;

                    a = Program.DoubleFromText(textBox1.Text);
                    b = Program.DoubleFromText(textBox2.Text);
                    h = Program.DoubleFromText(textBox3.Text);

                    A = Program.DoubleFromText(textBox4.Text);

                    if (h == 0.0000000)
                    {
                        MessageBox.Show("Значение(я) равны 0", "Проблема");
                        return;
                    }
                    x = a;

                    while (x <= b)
                    {
                        y = A * Math.Cos(x + 0.5) + 5;
                        this.chart1.Series[0].Points.AddXY(x, y);
                        x += h;
                    }

                    a2 = Program.DoubleFromText(textBox8.Text);
                    b2 = Program.DoubleFromText(textBox7.Text);
                    h2 = Program.DoubleFromText(textBox6.Text);
                    B = Program.DoubleFromText(textBox5.Text);

                    if (h2 == 0.0000000)
                    {
                        MessageBox.Show("Значение(я)  равны 0", "Проблема");
                        return;
                    }

                    x = a2;

                    while (x <= b2)
                    {
                        y = 1 - (B * Math.Sin(x + 0.5));
                        this.chart1.Series[1].Points.AddXY(x, y);
                        x += h2;
                    }
                }
                
            }
            catch
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.Charts.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
