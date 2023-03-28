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
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
            InitializeComponent();
            toolStripStatusLabel1.Text = DateTime.Now.Date.ToString().Split(' ')[0];
            toolStripStatusLabel2.Text = DateTime.Now.TimeOfDay.ToString().Split('.')[0];
            toolStripStatusLabel3.Text = "Файл не выбран";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.TextFiles.Show();
            Program.Text.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    StreamReader stream = new StreamReader(openFileDialog1.FileName);
                    string temp = stream.ReadLine();
                    while (temp != null)
                    {
                        textBox1.Text += temp + " ";
                        temp = stream.ReadLine();
                    }
                    toolStripStatusLabel3.Text = openFileDialog1.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    StreamWriter str = new StreamWriter(saveFileDialog1.FileName, false);
                    str.WriteLine(textBox1.Text);
                    button3.Enabled = true;
                    button5.Enabled = true;
                    toolStripStatusLabel3.Text = saveFileDialog1.FileName;
                    str.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Date.ToString().Split(' ')[0];
            toolStripStatusLabel2.Text = DateTime.Now.TimeOfDay.ToString().Split('.')[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                List<string> list2 = new List<string>();
                int q = 0;
                foreach (var item in textBox1.Text.Split(' '))
                    list.Add(item);
                List<string> index = new List<string>();
                while (list.Count > 3)
                {
                    list2 = list.Distinct().ToList();

                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list2.Count; j++)
                        {
                            if (list[i] == list2[j])
                            {
                                index.Add(list[i]);
                                i++;
                            }
                        }
                    }
                    foreach (var item in index)
                    {
                        if (list.Count > 3)
                        {
                            list.Remove(item);
                        }
                    }
                }
                foreach (var item in list)
                    comboBox1.Items.Add(item);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox1.Clear();
        }

        private void Form34_Load(object sender, EventArgs e)
        {

        }
    }
}
