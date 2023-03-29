using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice
{
    public partial class Form37 : Form
    {
        public Form37()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                    string temp = streamReader.ReadLine();
                    List<string> list = new List<string>();
                    while (temp != null)
                    {
                        list.Add(temp);
                        temp = streamReader.ReadLine();
                    }
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < list.Count; i++)
                    {
                        dataGridView1.Rows.Add(list[i].Split(' ')[0], list[i].Split(' ')[1], list[i].Split(' ')[2], list[i].Split(' ')[3]);
                    }


                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.WorkWithTypedFiles.Show();
            Program.Records.Hide();
        }
    }
}
