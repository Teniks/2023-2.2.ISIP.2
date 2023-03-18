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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> Numbers = new List<int>() { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22};
            int[] Count = new int[Numbers.Count];
            


            for (int j = 0; j < Numbers.Count; j++)
            {
                int counter = 0;

                for (int i = 2; i < 9; i++)
                {
                    if(Numbers[j] != i)
                    {
                        if (Numbers[j] % i == 0)
                        {
                            counter++;
                        }
                    }
                    
                    Count[j] = counter;
                }
            }


            textBox1.Text = "";
            textBox2.Text = "";

            for (int i = 0; i < Numbers.Count; i++)
            {
                if (Count[i] == 0)
                {
                    textBox1.Text += " " + Convert.ToString(Numbers[i]);
                }
                else
                {
                    textBox2.Text += " " + Convert.ToString(Numbers[i]);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Sets.Show();
            Program.Sets1.Hide();
        }
    }
}
