using System;
using System.Collections.Generic;
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

namespace _3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void compute()
        {

            try
            {

                int number = int.Parse(Number.Text);
                double value = double.Parse(Value.Text);

                string result = "";


                // все параметры треугольника на плоскости в евклидовом пространстве, значит должны быть положительны
                if (value > 0) { }

                else { throw new ArgumentOutOfRangeException(); }



                switch (number)
                {
                    // val = a
                    case 1:

                        result += $"2 - {Math.Round(value * Math.Sqrt(2), 2)}; ";
                        result += $"3 - {Math.Round(value * Math.Sqrt(2) / 2.0, 2)}; ";
                        result += $"4 - {Math.Round(value * value, 2)}";

                        Result.Content = result;
                        break;



                    // val = c
                    case 2:

                        result += $"1 - {Math.Round(value * Math.Sqrt(2) / 2, 2)}; ";
                        result += $"3 - {Math.Round(value / 2, 2)}; ";
                        result += $"4 - {Math.Round(value * value / 2, 2)}";

                        Result.Content = result;
                        break;



                    // val = h
                    case 3:

                        result += $"1 - {Math.Round(value * Math.Sqrt(2), 2)}; ";
                        result += $"2 - {Math.Round(value * 2, 2)}; ";
                        result += $"4 - {Math.Round(value * value, 2)}";

                        Result.Content = result;
                        break;



                    // val = S
                    case 4:

                        result += $"1 - {Math.Round(Math.Sqrt(2 * value), 2)}; ";
                        result += $"2 - {Math.Round(2 * Math.Sqrt(value), 2)}; ";
                        result += $"3 - {Math.Round(Math.Sqrt(value), 2)}";

                        Result.Content = result;
                        break;



                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            catch
            {
                Result.Content = "-";
            }
        }


        private void Value_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
