using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Practice15_Grebenukov
{
    public partial class Form1 : Form
    {
        private List<ComplexNumber> numbers = new List<ComplexNumber>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //    openFileDialog1.Filter = "Text Files|*.txt";
            //    openFileDialog1.ToString();
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        //string fileName = Path.GetFileName(openFileDialog1.FileName);
            //        string[] lines = File.ReadAllLines(openFileDialog1.FileName);
            //        foreach (string line in lines)
            //        {
            //            string[] parts = line.Split(';');
            //            double real = double.Parse(parts[0]);
            //            double imaginary = double.Parse(parts[1].Replace("i", ""));
            //            ComplexNumber number = new ComplexNumber(real, imaginary);
            //            numbers.Add(number);
            //        }

            //        foreach (ComplexNumber number in numbers)
            //        {
            //            listBoxComplexNumber.Items.Add($"{number.Real} + {number.Imaginary}");
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ошибка чтения из файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
                


        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Text Files|*.txt";
                openFileDialog1.ToString();
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //string fileName = Path.GetFileName(openFileDialog1.FileName);
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                    if(lines.Length == 0)
                    {
                        MessageBox.Show("Файл пуст", "Ошибка");
                    }
                    else
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(';');
                            double real = double.Parse(parts[0]);
                            double imaginary = double.Parse(parts[1].Replace("i", ""));
                            ComplexNumber number = new ComplexNumber(real, imaginary);
                            numbers.Add(number);
                        }

                        foreach (ComplexNumber number in numbers)
                        {
                            listBoxComplexNumber.Items.Add($"{number.Real};{number.Imaginary}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void OperationsButtonFile_Click(object sender, EventArgs e)
        {
            var count = listBoxComplexNumber.SelectedItems.Count;

            if(count == 2)
            {
                string result = "";
                string selectedItems = String.Join(";", listBoxComplexNumber.SelectedItems.Cast<string>().ToArray());
                string[] parts = selectedItems.Split(";");
                //double real1 = double.Parse(parts[0].Replace(',', '.'));
                //double imaginary1 = double.Parse(parts[1].Replace(',', '.'));
                //double real2 = double.Parse(parts[2].Replace(',', '.'));
                //double imaginary2 = double.Parse(parts[3].Replace(',', '.'));
                double real1 = double.Parse(parts[0]);
                double imaginary1 = double.Parse(parts[1]);
                double real2 = double.Parse(parts[2]);
                double imaginary2 = double.Parse(parts[3]);
                ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
                ComplexNumber number2 = new ComplexNumber(real2, imaginary2);
                if (comboBoxOperations.SelectedItem == null)
                {
                    MessageBox.Show("Выберите операцию в ComboBox", "Ошибка");
                }
                else
                {
                    string operation = comboBoxOperations.SelectedItem.ToString();
                    switch (operation)
                    {
                        case "Сложение":
                            result = number1.Add(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Умножение":
                            result = number1.Add(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Вычитание":
                            result = number1.Add(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Выберите два значения", "Ошибка");
            }
        }

        private void OperationsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";
                double real1 = double.Parse(textBoxNumber1.Text);
                double imaginary1 = double.Parse(textBoxNumber2.Text);
                double real2 = double.Parse(textBoxNumber3.Text);
                double imaginary2 = double.Parse(textBoxNumber4.Text);
                ComplexNumber number1 = new ComplexNumber(real1, imaginary1);
                ComplexNumber number2 = new ComplexNumber(real2, imaginary2);
                if (comboBoxOperations.SelectedItem == null)
                {
                    MessageBox.Show("Выберите операцию в ComboBox", "Ошибка");
                }
                else
                {
                    string operation = comboBoxOperations.SelectedItem.ToString();
                    switch (operation)
                    {
                        case "Сложение":
                            result = number1.Add(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Умножение":
                            result = number1.Add(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                        case "Вычитание":
                            result = number1.Add(number2).ToString();
                            MessageBox.Show(result, "Ответ");
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }
    }
}
