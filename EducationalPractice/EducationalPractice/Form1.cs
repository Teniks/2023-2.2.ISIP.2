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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Bridge.Show();
            Program.Center.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Sets.Show();
            Program.Center.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.WorkingWithLists.Show();
            Program.Center.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.WorkingWithMass.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Lists.Show();
            Program.Center.Hide();
        }
    }
}
