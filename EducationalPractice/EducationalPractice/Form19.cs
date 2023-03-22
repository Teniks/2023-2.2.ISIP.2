using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace EducationalPractice
{
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Rows.Hide();
            Program.WorkingWithMass.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "")
            {
                textBox1.Text += textBox2.Text + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Clear();
            
            string word = textBox1.Text;
            string boofer = "";
            List<string> words = new List<string>();

            word = Regex.Replace(word, @"[ \n]", "");


            for (int i = 0; i < word.Length; i++)
            {
                if(Char.IsControl(word[i]))
                {
                    words.Add(boofer);
                    boofer = "";
                }
                else
                {

                    boofer += word[i];
                }
            }
            words.Add(boofer);

            List<string> processedWords = words.FindAll(p => p.Length > 0);

            label2.Text = Convert.ToString(processedWords.Count);

        }

        private void Form19_Load(object sender, EventArgs e)
        {

        }
    }
}
