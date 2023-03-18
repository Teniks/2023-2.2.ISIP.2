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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.Sets.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Sets1.Show();
            Program.Sets.Hide();
        }
    }
}
