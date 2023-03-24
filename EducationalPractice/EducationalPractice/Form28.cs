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
    public partial class Form28 : Form
    {
        public Form28()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Animation.Show();
            Program.Stopwatch.Hide();
        }

        int i;
        int tik;
        


        private void button1_Click(object sender, EventArgs e)
        {
            
            i = 0;
            timer1.Interval = 10000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tik = --i;
            if (--i < 0)
            {
                timer1.Stop();
                MessageBox.Show("Прошла минута", "Уведомление"); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
