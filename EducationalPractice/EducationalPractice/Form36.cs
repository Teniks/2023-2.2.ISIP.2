using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EducationalPractice
{
    public partial class Form36 : Form
    {
        string[] Data;
        string TB;
        string Result;

        public Form36()
        {
            InitializeComponent();
        }

        private void Form36_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                string[] NameColumns = { "Модель", "Номер", "ФИО", "Дата последнего техосмотра" };
                string[] NC2 = { "Model", "Number", "FNameSName", "TechLooking" };
                dataGridView1.Columns.Add(NC2[i], NameColumns[i]);
            }
            ((DataGridViewTextBoxColumn)dataGridView1.Columns[0]).MaxInputLength = 10;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Data = new string[dataGridView1.RowCount];
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                Data[i] = dataGridView1[1, i].Value.ToString();
            }
            TB = Convert.ToString(textBox1.Text);

            SearchCarNumber Car = new SearchCarNumber(TB, Data);
            string first = Convert.ToString(dataGridView1[0, Convert.ToInt32(Car.Search())].Value?.ToString()) ?? "Пусто";
            string second = Convert.ToString(dataGridView1[1, Convert.ToInt32(Car.Search())].Value?.ToString()) ?? "Пусто";
            string thried = Convert.ToString(dataGridView1[2, Convert.ToInt32(Car.Search())].Value?.ToString()) ?? "Пусто";
            string fourth = Convert.ToString(dataGridView1[3, Convert.ToInt32(Car.Search())].Value?.ToString()) ?? "Пусто";

            Result = $"{first} -- {second} \r {fourth} \r {thried}";

            MessageBox.Show(Convert.ToString(Result));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.WorkWithTypedFiles.Show();
            Program.Notes.Hide();
        }
    }

    public class SearchCarNumber
    {
        private string CarNumber;
        private string[] DataCar;
        int Number;

        public string Search()
        {
            for (int i = 0; i < DataCar.Length; i++)
            {
                if (DataCar[i] == CarNumber)
                {
                    Number = i;
                }
            }
            return Number.ToString();
        }

        public SearchCarNumber(string _CarNumber, string[] dataGrid)
        {
            CarNumber = _CarNumber;
            DataCar = dataGrid;
        }
    }
}
