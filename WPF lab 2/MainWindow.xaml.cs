using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_lab_2
{
    static class logicForIfTask
    {
        public static string SintRub(int ruble, int penny)
        {
            if (ruble == 1 & penny == 0)
            {
                return "один рубль ровно";
            }
            else if (ruble >= 10 & ruble <= 20)
            {
                return ruble.ToString() + " рублей";
            }
            else if (ruble % 10 == 1)
            {
                return ruble.ToString() + " рубль";
            }
            else if ((ruble % 10) > 1 & (ruble % 10) <= 4)
            {
                return ruble.ToString() + " рубля";
            }
            else
            {
                return ruble.ToString() + " рублей";
            }
        }

        public static string SintPenny(int penny)
        {
            if (penny == 0)
            {
                return string.Empty;
            }
            else if (penny % 10 == 1)
            {
                return penny.ToString() + " копейка";
            }
            else if (penny >= 10 & penny <= 20)
            {
                return penny.ToString() + " копеек";
            }
            else if ((penny % 10) > 1 & (penny % 10) <= 4)
            {
                return penny.ToString() + " копейки";
            }
            else
            {
                return penny.ToString() + " копеек";
            }
        }


    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("text.txt");
            text1.Text = reader.ReadLine();
            reader.Close();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text == "\r\n")
            {
                MessageBox.Show("неверное число");
            }
            else
            {
                int number = int.Parse(text1.Text);
                int ruble = 0, penny = 0;
                //проверка введеных данных
                if (0 >= number || 10000 <= number)
                {
                    MessageBox.Show("неверное число");

                }
                else
                {
                    penny = number % 100;
                    ruble = (number / 100);
                    answerBox.Text=(logicForIfTask.SintRub(ruble, penny) + " " + logicForIfTask.SintPenny(penny));
                }
            }

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Задача №12. Дано натуральное число 1≤n≤9999," +
                " определяющее стоимость товара в копейках." +
                " Выразить стоимость в рублях и копейках," +
                " например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т. п.");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = string.Empty;
            answerBox.Text = string.Empty;
        }

        private void text1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if ((e.Text) == null || !(e.Text).All(char.IsDigit))
            {
                e.Handled = true;
            }
        }

        private void text1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && text1.Text != string.Empty)
            {
                int number = int.Parse(text1.Text);
                int ruble = 0, penny = 0;
                //проверка введеных данных
                if (0 >= number || 10000 <= number)
                {
                    MessageBox.Show("неверное число");

                }
                else
                {
                    penny = number % 100;
                    ruble = (number / 100);
                    answerBox.Text = (logicForIfTask.SintRub(ruble, penny) + " " + logicForIfTask.SintPenny(penny));
                }
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            File.WriteAllText("text.txt", text1.Text);
        }
    }
}
