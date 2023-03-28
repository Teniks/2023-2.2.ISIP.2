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
        public static Form11 Recursion = new Form11();
        public static Form12 WorkingWithLists = new Form12();
        public static Form13 FruitTree = new Form13();
        public static Form16 LinkedLists = new Form16();
        public static Form18 WorkingWithMass = new Form18();
        public static Form19 Rows = new Form19();
        public static Form20 SortMassive = new Form20();
        public static Form21 Lines = new Form21();
        public static Form22 Lists = new Form22();
        public static Form23 ListsAndSwitches = new Form23();
        public static Form24 Subroutines = new Form24();
        public static Form25 Division = new Form25();
        public static Form26 Charts = new Form26();
        public static Form27 Animation = new Form27();
        public static Form28 Stopwatch = new Form28();
        public static Form29 Animation1 = new Form29();
        public static Form31 GraphicsAndMovement = new Form31();
        public static Form32 Multimedia = new Form32();
        public static Form33 TextFiles = new Form33();
        public static Form34 Text = new Form34();


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
                MessageBox.Show("Введите число","Проблема");
                return 0.0;
            }
            
        }

        public static int C(int m, int n)
        {
            int res = m+n;
            if (n == 0)
            {
                return 1;
            }
            if (0 < m && m < n)
            {
                return (factorial(n)) / (factorial(m) * (factorial(n - m)));
            }

            MessageBox.Show("Возникло исключение в условии", "Проблема");
            return res;

        }
        public static int factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    static class Data
    {
        public static List<object> listBoofer = new List<object>();
        public static int[] massBoofer;
        public static List<string> stringListBoofer = new List<string>();
    }
} 
