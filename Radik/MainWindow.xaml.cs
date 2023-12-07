using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace kochergin_225_4
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

                int index = int.Parse(First.Text);

                string text = Second.Text;

                string pattern = @",";
                string target = ".";
                Regex regex = new Regex(pattern);
                string result = regex.Replace(text, target);

                double weight = double.Parse(result);



                switch (index)
                {

                    // килограмм
                    case 1:
                        Result.Content = $"{Math.Round(weight, 6)}";
                        break;

                    // миллиграмм
                    case 2:
                        Result.Content = $"{Math.Round(0.000001 * weight, 9)}";
                        break;

                    // грамм
                    case 3:
                        Result.Content = $"{Math.Round(0.001 * weight, 6)}";
                        break;

                    // тонна
                    case 4:
                        Result.Content = $"{Math.Round(1000 * weight, 6)}";
                        break;

                    // центнер
                    case 5:
                        Result.Content = $"{Math.Round(100 * weight, 6)}";
                        break;

                    default:
                        Result.Content = "-";
                        break;
                }
            }

            catch
            {
                Result.Content = "-";
            }

        }


        private void First_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }

        private void Second_TextChanged(object sender, TextChangedEventArgs e)
        {
            compute();
        }
    }
}
