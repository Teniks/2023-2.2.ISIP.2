﻿using System;
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
        public static List<object> Boofer = new List<object>();
        public static List<object> Boofer1 = new List<object>();
    }
} 
