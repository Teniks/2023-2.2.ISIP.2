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
    public partial class Form14 : Form
    {
        public Form14(ListBox listBox)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавить
            if(listBox1.Items.IndexOf(textBox1.Text) == -1)
            {
                if(Data.listBoofer.IndexOf(textBox1.Text) == -1)
                {
                    listBox1.Items.Add(textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("Элемент есть в списке","Проблема");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Удалить
            if (textBox1.Text != "")
            {
                if (listBox1.Items.IndexOf(textBox1.Text) > 0)
                {
                    if (Data.listBoofer.IndexOf(textBox1.Text) > 0)
                    {
                        listBox1.Items.RemoveAt(Data.listBoofer.IndexOf(textBox1.Text));
                        Data.listBoofer.RemoveAt(Data.listBoofer.IndexOf(textBox1.Text));
                    }
                }
                else
                {
                    MessageBox.Show("Элемента нет в списке", "Проблема");
                }
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }
        
        private void Form14_Load(object sender, EventArgs e)
        {
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

            if (Program.FruitTree.addORdel)
            {
                button1.BringToFront();
            }
            else
            {
                button2.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Сохранить

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (Data.listBoofer.IndexOf(listBox1.Items[i]) == -1)
                {
                    Data.listBoofer.Add(listBox1.Items[i]);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
