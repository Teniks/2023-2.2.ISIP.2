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
    public partial class Form33 : Form
    {
        public Form33()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.TextFiles.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Text.Show();
            Program.TextFiles.Hide();
        }
    }
}
