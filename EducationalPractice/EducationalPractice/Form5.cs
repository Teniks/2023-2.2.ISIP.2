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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Branching2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Branching.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Branching3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            this.Hide();

        }
    }
}
