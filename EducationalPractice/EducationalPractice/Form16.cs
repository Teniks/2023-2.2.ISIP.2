using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EducationalPractice
{
    public partial class Form16 : Form
    {
        string text = "";
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();

            try
            {
                string path = @"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Ex-3.txt";

                if (textBox1.Text == "")
                {


                    text = "";
                    string line;
                    StreamReader ReverseText = new StreamReader(path);
                    while ((line = ReverseText.ReadLine()) != null)
                    {
                        text += line;
                    }
                }
                else
                {
                    text = textBox1.Text;
                    textBox1.Clear();
                }

                textBox2.Text = text;
            }
            catch
            {
                text = textBox1.Text;
                textBox1.Clear();
                textBox2.Text = text;

                MessageBox.Show("Ссылка на текст не действительна. Выполните ввод текста вручную","Проблема");

                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text = "";

            string[] reverse;
            reverse = text.Split(new char[] { ' ' });
            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                textBox2.Text += " " + reverse[i];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.WorkingWithLists.Show();
            Program.LinkedLists.Hide();
        }
    }
}
