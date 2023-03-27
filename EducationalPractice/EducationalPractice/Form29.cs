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
    public partial class Form29 : Form
    {
        int i = 0;
        Image k1 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet.png");
        Image k2 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet1.png");
        Image k3 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet2.png");
        Image k4 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet3.png");
        Image k5 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet4.png");
        Image k6 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet5.png");
        Image k7 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet6.png");
        Image k8 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet7.png");
        Image k9 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet8.png");
        Image k10 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet9.png");
        Image k11 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet10.png");
        Image k12 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet11.png");
        Image k13 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet12.png");
        Image k14 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet13.png");
        Image k15 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet14.png");
        Image k16 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet15.png");
        Image k17 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet16.png");
        Image k18 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet17.png");
        Image k19 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet18.png");
        Image k20 = Image.FromFile(@"C:\2023-2.2.ISIP.2\EducationalPractice\Resource\Sprite-0004-Sheet19.png");


        public Form29()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Animation.Show();
            Program.Animation1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                button2.Text = "Старт";
            }
            else
            {
                timer1.Start();
                button2.Text = "Стоп";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (i == 1)
            {
                pictureBox1.Image = k1;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 2)
            {
                pictureBox1.Image = k2;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 3)
            {
                pictureBox1.Image = k3;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 4)
            {
                pictureBox1.Image = k4;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 5)
            {
                pictureBox1.Image = k5;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 6)
            {
                pictureBox1.Image = k6;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 7)
            {
                pictureBox1.Image = k7;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 8)
            {
                pictureBox1.Image = k8;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 9)
            {
                pictureBox1.Image = k9;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 10)
            {
                pictureBox1.Image = k10;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 11)
            {
                pictureBox1.Image = k11;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 12)
            {
                pictureBox1.Image = k12;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 13)
            {
                pictureBox1.Image = k13;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 14)
            {
                pictureBox1.Image = k14;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 15)
            {
                pictureBox1.Image = k15;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 16)
            {
                pictureBox1.Image = k16;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 17)
            {
                pictureBox1.Image = k17;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 18)
            {
                pictureBox1.Image = k18;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 19)
            {
                pictureBox1.Image = k19;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i == 20)
            {
                pictureBox1.Image = k20;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (i > 20)
            {
                i = 0;
            }

            i++;
        }
    }

}
