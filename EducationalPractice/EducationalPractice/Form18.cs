﻿using System;
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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 Mass = new Form17();
            Mass.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Hide();
            Program.Rows.Show();
        }

        private void Form18_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Hide();
            Program.SortMassive.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Hide();
            Program.Lines.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
