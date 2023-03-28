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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int counter = 0;
                int number = 0;
                bool numIsLenght = false;
                bool singleNumber = false;
                string[] textArr = textBox1.Text.Split(new char[] {' ', ',', '.', ':', ':', '(', ')', '?', '!'},
                                                 StringSplitOptions.RemoveEmptyEntries).ToArray();
                string text = textArr[0];
                if (textArr.Length > 1)
                {
                    for (int i = 1; i < textArr.Length; i++)
                    {
                        text += textArr[i];
                    }
                }
                textBox1.Text = text;

                for (int i = 0; i < text.Length; i++)
                {
                    if (Char.IsDigit(text[i]))
                    {
                        counter++;
                        number = Convert.ToInt32(text[i].ToString());
                    }
                }
                if (counter == 1)
                {
                    singleNumber = true;
                    numIsLenght = text.Length == number;
                }

                label1.Text = "Число одно - " + singleNumber;
                label2.Text = "Число = длине строки - " + numIsLenght;
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Show();
            Program.Lines.Hide();
        }
    }
}
