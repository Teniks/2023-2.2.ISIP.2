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
    public partial class Form39 : Form
    {
        public Form39()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                Program.Center.Show();
                Hide();
                timer1.Stop();
            }
            else
            {
                progressBar1.Value += 1;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
