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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Pirogov-Kopeikina\EducationalPractice\Resource\Screenshot_3.png");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (IsNumeric(textBox1))
                {
                    int x = Convert.ToInt32(textBox1.Text);
                    int y = 0;
                    try
                    {
                        if (x > 0)
                        {
                            y = -2 * (x * x) + 3;
                        }
                        else
                        {
                            y = -2 * (x * x) + x + 1;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка просчета", "Проблема");
                    }
                    label2.Text = Convert.ToString(y);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода", "Проблема");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.Branching.Hide();
        }
        private bool IsNumeric(TextBox textbox)
        {
            bool isNumeric = false;
            try
            {
                string IN = Convert.ToString(textbox.Text);
                isNumeric = IN.All(char.IsDigit); 
            }
            catch
            {
                MessageBox.Show("Ошибка метода проверки", "Проблема");
            }
            return isNumeric;
        }
    }
}
