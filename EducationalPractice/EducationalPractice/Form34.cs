using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalPractice
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.TextFiles.Show();
            Program.Text.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //открыть

            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    StreamReader stream = new StreamReader(openFileDialog1.FileName);
                    textBox1.Clear();

                    string temp = stream.ReadLine();
                    while (temp != null)
                    {
                        textBox1.Text += temp + " ";
                        temp = stream.ReadLine();
                    }

                    toolStripStatusLabel3.Text = openFileDialog1.FileName;
                }
                CounterWords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Проблема");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    StreamWriter str = new StreamWriter(saveFileDialog1.FileName, false);

                    str.WriteLine(textBox1.Text);
                    toolStripStatusLabel3.Text = saveFileDialog1.FileName;
                    str.Close();


                    button3.Enabled = true;
                    button5.Enabled = true;
                }
                CounterWords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Проблема");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Date.ToString().Split(' ')[0];
            toolStripStatusLabel2.Text = DateTime.Now.TimeOfDay.ToString().Split('.')[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Найти
            label1.Text = Convert.ToString(Data.stringListBoofer[Data.stringListBoofer.IndexOf(Convert.ToString(comboBox1.SelectedItem))+1]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;

            button5.Enabled = false;
            button3.Enabled = false;

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            toolStripStatusLabel1.Text = DateTime.Now.Date.ToString().Split(' ')[0];
            toolStripStatusLabel2.Text = DateTime.Now.TimeOfDay.ToString().Split('.')[0];
            toolStripStatusLabel3.Text = "Файл не выбран";
        }

        public void CounterWords()
        {
            try
            {
                comboBox1.Items.Clear();
            }
            catch
            {

            }
            try
            {
                List<string> TextBoxList = new List<string>();

                foreach (var item in textBox1.Text.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (item.Length > 1 && item != "Я" && item != "я")
                    {
                        TextBoxList.Add(item);
                    }

                }

                string[] wordsAndThemNumbers = new string[TextBoxList.Count*2];
                int wATNcounter = 0;
                int counter = 0;

                for (int i = 0; i < TextBoxList.Count; i++)
                {
                    counter = 0;
                    for (int j = 0; j < TextBoxList.Count; j++)
                    {
                        if (TextBoxList[i] == TextBoxList[j])
                        {
                            counter++;
                        }
                    }
                    if(wATNcounter+2 <= wordsAndThemNumbers.Length)
                    {
                        wordsAndThemNumbers[wATNcounter] = TextBoxList[i];
                        wordsAndThemNumbers[wATNcounter+1] = Convert.ToString(counter);
                        wATNcounter += 2;
                    }
                }

                int lenghtNewArray = 0;
                for (int i = 1; i < wordsAndThemNumbers.Length; i += 2)
                {
                    if (Convert.ToInt32(wordsAndThemNumbers[i]) < 2)
                    {
                        wordsAndThemNumbers[i] = " ";
                        wordsAndThemNumbers[i - 1] = " ";
                    }
                    else
                    {
                        lenghtNewArray++;
                    }
                }

                string trim = "";
                for (int i = 0; i < wordsAndThemNumbers.Length; i ++)
                {
                    trim += wordsAndThemNumbers[i] + " ";
                }
                string[] duplicatesAndThemNumbers = trim.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < duplicatesAndThemNumbers.Length; i += 2)
                {
                    for (int j = 0; j < duplicatesAndThemNumbers.Length; j += 2)
                    {
                        if (duplicatesAndThemNumbers[i] == duplicatesAndThemNumbers[j] && i != j)
                        {
                            duplicatesAndThemNumbers[j] = " ";
                            duplicatesAndThemNumbers[j + 1] = " ";
                        }
                    }
                }

                trim = "";
                for (int i = 0; i < duplicatesAndThemNumbers.Length; i++)
                {
                    trim +=duplicatesAndThemNumbers[i] + " ";
                }
                duplicatesAndThemNumbers = trim.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < duplicatesAndThemNumbers.Length; i += 2)
                {
                    comboBox1.Items.Add(duplicatesAndThemNumbers[i]);
                }

                for(int i = 0; i < duplicatesAndThemNumbers.Length; i++)
                {
                    Data.stringListBoofer.Add(duplicatesAndThemNumbers[i]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CounterWords");
            }
        }
    }
}
