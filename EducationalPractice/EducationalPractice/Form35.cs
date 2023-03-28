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
    public partial class Form35 : Form
    {
        public Form35()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.WorkWithTypedFiles.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Notes.Show();
            Program.WorkWithTypedFiles.Hide();
        }
    }
}
