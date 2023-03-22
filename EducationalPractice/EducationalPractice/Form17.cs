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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Value);
            int m = Convert.ToInt32(numericUpDown2.Value);

            if(n == 0 && m == 0)
            {
                return;
            }
            int[,] numbers = new int[n, m];

            Random num = new Random();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int t = 0; t < numbers.GetLength(1); t++)
                {
                    numbers[i, t] = num.Next(0, 3);
                }
            }

            List<int> lineNumber = new List<int>();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int counter = numbers.GetLength(1);

                for (int t = 0; t < numbers.GetLength(1); t++)
                {
                    if(numbers[i, t] == 0)
                    {
                        counter--;
                    }
                }

                if(counter == numbers.GetLength(1))
                {
                    lineNumber.Add(i);
                }
            }

            textBox1.Clear();
            foreach (int g in lineNumber)
            {
                
                textBox1.Text += g + 1;
            }

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int t = 0; t < numbers.GetLength(1); t++)
                {
                    dataGridView1.Rows[i].Cells[t].Value = numbers[i, t];
                }
            }

            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Show();
            this.Close();
        }
    }
}
