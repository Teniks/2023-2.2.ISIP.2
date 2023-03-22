using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice
{
    public partial class Form20 : Form
    { 
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SortMassive.Hide();
            Program.WorkingWithMass.Show();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                Random random = new Random();
                int[] Numbers = new int[Convert.ToInt32(numericUpDown1.Value)];

                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = random.Next(999);
                }

                Data.massBoofer = Numbers;
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            try
            {
                for (int i = 0; i < Data.massBoofer.Length; i++)
                {
                    textBox1.Text += Data.massBoofer[i] + " ";
                }
            }catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try
            {
                int temp;
                for (int i = 0; i < Data.massBoofer.Length - 1; i++)
                {
                    for(int j = i + 1; j < Data.massBoofer.Length; j++)
                    {
                        if (Data.massBoofer[i] < Data.massBoofer[j])
                        {
                            temp = Data.massBoofer[i];
                            Data.massBoofer[i] = Data.massBoofer[j];
                            Data.massBoofer[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < Data.massBoofer.Length; i++)
                {
                    listBox1.Items.Add(Data.massBoofer[i]);
                }

            }catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex = 0;

            }catch { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex = listBox1.Items.Count-1;

            }
            catch { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex++;

            }
            catch { listBox1.SelectedIndex = 0; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.SelectedIndex--;

            }
            catch { listBox1.SelectedIndex = listBox1.Items.Count - 1; }
        }
    }
    
}
