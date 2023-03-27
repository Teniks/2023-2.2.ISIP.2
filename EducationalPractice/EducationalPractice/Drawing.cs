using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPractice
{
    class Drawing
    {
        bool x1Direction = true;
        bool y1Direction = true;
        bool x2Direction = true;
        bool y2Direction = true;
        bool x3Direction = true;
        bool y3Direction = true;

        int d1 = 0;
        int d2 = 0;
        int d3 = 0;

        Point point1 = new Point(0, 0);
        Point point2 = new Point(0, 0);
        Point point3 = new Point(0, 0);
        Random rand = new Random();
        private Color RandomColor { get { return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)); } }

        int tick = 0;

        Form31 form;
        public Drawing (Form31 _form, int _d1, int _d2, int _d3)
        {
            form = _form;
            d1 = _d1;
            d2 = _d2;
            d3 = _d3;

            point1.Y = _d1 / 2;
            point2.Y = _d2 / 2;
            point3.Y = _d3 / 2;

            point1.X = _d1 / 2;
            point2.X = _d2 / 2;
            point3.X = _d3 / 2;

            i1 = -d1;
            i2 = -d2;
            i3 = -d3;
        }
        double i1 = 0;
        double i2 = 0;
        double i3 = 0;
        public void Move()
        {
            tick++;
            form.g.Clear(Color.White);
            form.g.DrawEllipse(Pens.Black, d1 + 15, d1 + 15, 3, 3);
            if (i1 < d1 && x1Direction)
            {
                Draw(new Pen(RandomColor), new Point((int)(i1) + d1+15, (int)Math.Sqrt(Math.Pow(d1, 2) - Math.Pow((int)(i1), 2)) + d1+15));
                i1++;

            }
            else
            {
                x1Direction = false;
                if (i1 > -d1 && !x1Direction)
                {
                    Draw(new Pen(RandomColor), new Point((int)(i1) + d1 + 15, -(int)Math.Sqrt(Math.Pow(d1, 2) - Math.Pow((i1), 2)) + d1 + 15));

                    i1--;

                }
                else
                {
                    x1Direction = true;
                }
            }
            
            
            ///////////////////////////////////////////////////////////////
            if (i2 < d2 && x2Direction)
            {
                i2++;
                Draw(new Pen(RandomColor), new Point((int)i2 + d1 + 15, (int)Math.Sqrt(Math.Pow(d2, 2) - Math.Pow(i2, 2)) + d1 + 15));
            }
            else
            {
                x2Direction = false;
            }
            if (i2 > -d2 && !x2Direction)
            {
                i2--;
                Draw(new Pen(RandomColor), new Point((int)i2 + d1 + 15, -(int)Math.Sqrt(Math.Pow(d2, 2) - Math.Pow(i2, 2)) + d1 + 15));
            }
            else
            {
                x2Direction = true;
            }
            /////////////////////////////////////////////////////////////
            if (i3 < d3 && x3Direction)
            {
                i3++;
                Draw(new Pen(RandomColor), new Point((int)i3 + d1 + 15, (int)Math.Sqrt(Math.Pow(d3, 2) - Math.Pow(i3, 2)) + d1 + 15));
            }
            else
            {
                x3Direction = false;
            }
            if (i3 > -d3 && !x3Direction)
            {
                i3--;
                Draw(new Pen(RandomColor), new Point((int)i3 + d1 + 15, -(int)Math.Sqrt(Math.Pow(d3, 2) - Math.Pow(i3, 2)) + d1 + 15));
            }
            else
            {
                x3Direction = true;
            }

        }

        public void Draw(Pen color, Point point1)
        {
            form.g.DrawEllipse(color, point1.X, point1.Y, 10, 10);
        }

        public Point DeterminePoint(int d, int x)
        {
            

            double y = d - Math.Sqrt(Math.Pow(x, 2));
            return new Point();
        }
    }
}
