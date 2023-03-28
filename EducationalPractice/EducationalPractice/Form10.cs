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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            double A = 1;
            double output = 0;

            try
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        string Number = Convert.ToString(dataGridView1.Rows[i].Cells[j].Value);
                        A *= Program.DoubleFromText(Number);

                        output += Math.Sqrt(A);
                    }
                }

                label1.Text = output.ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.RowCount = 1;
                dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Sets.Show();
            Program.For.Hide();
        }
    }
}
