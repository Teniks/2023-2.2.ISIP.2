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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("x-coor", "X-coordinate");
            dataGridView1.Columns.Add("y-coor", "Y-coordinate");
            dataGridView1.RowCount = 5;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) ||

                    Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value))
                {
                    MessageBox.Show("Точки находятся на одной прямой", "Проблема");
                    return;
                }
            }
            catch
            {

            }

            try
            {
                if (Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) ||

                    Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) ||

                    Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) ||
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) &&
                    Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) == Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value)
                    )
                {
                    MessageBox.Show("Точки совпадают", "Проблема");
                    return;
                }
            }
            catch
            {

            }

            try
            {
                if (dataGridView1.Rows[3].Cells[0].Value == null && dataGridView1.Rows[3].Cells[1].Value == null)
                {
                    dataGridView1.Rows[3].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) + Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) - Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value);
                    dataGridView1.Rows[3].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) - Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value);
                }
                if (dataGridView1.Rows[2].Cells[0].Value == null && dataGridView1.Rows[2].Cells[1].Value == null)
                {
                    dataGridView1.Rows[2].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) + Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) - Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
                    dataGridView1.Rows[2].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) - Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value);
                }
                if (dataGridView1.Rows[1].Cells[0].Value == null && dataGridView1.Rows[1].Cells[1].Value == null)
                {
                    dataGridView1.Rows[1].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value) + Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value) - Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value);
                    dataGridView1.Rows[1].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value) - Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value);
                }
                if (dataGridView1.Rows[0].Cells[0].Value == null && dataGridView1.Rows[0].Cells[1].Value == null)
                {
                    dataGridView1.Rows[0].Cells[0].Value = Convert.ToInt32(dataGridView1.Rows[1].Cells[0].Value) + Convert.ToInt32(dataGridView1.Rows[3].Cells[0].Value) - Convert.ToInt32(dataGridView1.Rows[2].Cells[0].Value);
                    dataGridView1.Rows[0].Cells[1].Value = Convert.ToInt32(dataGridView1.Rows[1].Cells[1].Value) + Convert.ToInt32(dataGridView1.Rows[3].Cells[1].Value) - Convert.ToInt32(dataGridView1.Rows[2].Cells[1].Value);
                }
            }
            catch
            {
                MessageBox.Show("Точно ввели числа?", "Проблема");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.MathAndPHysicalTascks.Hide();
        }
    }
}
