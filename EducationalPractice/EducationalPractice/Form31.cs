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
    public partial class Form31 : Form
    {
        private Drawing Drawing;
        public Graphics g;

        public Form31()
        {
            InitializeComponent();
            DoubleBuffered = true;
            g = CreateGraphics();
            Drawing = new Drawing(this, 60, 45, 25);
        }

        int i;
        SolidBrush inside;
        
        
        


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Animation.Show();
            Program.GraphicsAndMovement.Hide();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (timer1.Enabled)
            {
                timer1.Stop();
                button1.Text = "Старт";
            }
            else
            {
                timer1.Start();
                button1.Text = "Стоп";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Drawing.Move();
        }
    }
}
