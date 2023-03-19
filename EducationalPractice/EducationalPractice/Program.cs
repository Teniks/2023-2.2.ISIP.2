using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EducationalPractice
{
    static class Program
    {
        public static Form1 Center = new Form1();
        public static Form1_1 Bridge = new Form1_1();
        public static Form2 MathAndPHysicalTascks = new Form2();
        public static Form3 Branching = new Form3();
        public static Form4 Branching2 = new Form4();
        public static Form5 BranchingChoice = new Form5();
        public static Form6 Branching3 = new Form6();
        public static Form7 Sets = new Form7();
        public static Form8 Sets1 = new Form8();
        public static Form9 While = new Form9();
        public static Form10 For = new Form10();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(Center);
        }
        public static double DoubleFromText(string str)
        {
            try
            {
                string input = str.Replace('.', ',');
                double A = Convert.ToDouble(input);

                return A;
            }
            catch
            {
                return 0.0;
            }
            
        }
    }
} 
