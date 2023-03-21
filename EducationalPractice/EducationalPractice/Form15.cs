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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            

            int a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12;


            Random Rand = new Random();

            int[] a = new int[]
            {
                a1 = Rand.Next(0, 144),
                a2 = Rand.Next(0, 144),
                a3 = Rand.Next(0, 144),
                a4 = Rand.Next(0, 144),
                a5 = Rand.Next(0, 144),
                a6 = Rand.Next(0, 144),
                a7 = Rand.Next(0, 144),
                a8 = Rand.Next(0, 144),
                a9 = Rand.Next(0, 144),
                a10 = Rand.Next(0, 144),
                a11 = Rand.Next(0, 144),
                a12 = Rand.Next(0, 144)
            };

            dataGridView1.ColumnCount = 4;
            dataGridView1.RowCount = 4;
            int aCount = 0;
            int n = 3;
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j ++)
                {
                    if(aCount < a.Length)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = a[aCount];
                    }

                    j = i == 0 && j == 1 ? j += 3 : j;
                    j = i == 1 && j == 0 ? j += 3 : j;
                    j = i == 2 && j == 2 ? j += 3 : j;
                    j = i == 3 && j == 2 ? j += 3 : j;

                    aCount++;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.WorkingWithLists.Show();
            this.Close();
        }
    }
}
