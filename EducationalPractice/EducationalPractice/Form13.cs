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
    public partial class Form13 : Form
    {
        public bool addORdel;

        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.FruitTree.Hide();
            Program.WorkingWithLists.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 AddOrDel = new Form14(listBox1);
            addORdel = true;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Data.listBoofer.IndexOf(listBox1.Items[i]) == -1)
                {
                    Data.listBoofer.Add(listBox1.Items[i]);
                }
            }
            AddOrDel.ShowDialog();
            try
            {
                listBox1.Items.Clear();
                for (int i = 0; i < Data.listBoofer.Count; i++)
                {
                    
                    listBox1.Items.Add(Data.listBoofer[i]);
                }
            }
            catch
            {

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 AddOrDel = new Form14(listBox1);
            addORdel = false;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Data.listBoofer.IndexOf(listBox1.Items[i]) == -1)
                {
                    Data.listBoofer.Add(listBox1.Items[i]);
                }
            }
            AddOrDel.ShowDialog();

            try
            {
                listBox1.Items.Clear();
                for (int i = 0; i < Data.listBoofer.Count; i++)
                {

                    listBox1.Items.Add(Data.listBoofer[i]);
                }
            }
            catch
            {

            }
        }
    }
}
