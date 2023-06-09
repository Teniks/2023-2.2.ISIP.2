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
    public partial class Form1_1 : Form
    {
        public Form1_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Математические и физические задачи
            Program.MathAndPHysicalTascks.Show();
            Program.Bridge.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.BranchingChoice.Show();
            Program.Bridge.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.Center.Show();
            Program.Bridge.Hide();
        }
    }
}
